import requests
import time
import hashlib
import json
import os
from datetime import datetime

# ─────────────────────────────────────────
#  CONFIG — fill these in before running
# ─────────────────────────────────────────
TELEGRAM_BOT_TOKEN = "YOUR_BOT_TOKEN_HERE"
TELEGRAM_CHAT_ID   = "YOUR_CHAT_ID_HERE"

CHECK_INTERVAL_SECONDS = 300  # check every 5 minutes

# ─────────────────────────────────────────
#  SOURCES TO MONITOR
# ─────────────────────────────────────────
SOURCES = [
    {
        "name": "RCB Official Tickets Page",
        "url": "https://www.royalchallengers.com/tickets",
    },
    {
        "name": "Nitter RCB Twitter Feed",
        "url": "https://nitter.poast.org/RCBTweets",
    },
    {
        "name": "Nitter IPL Twitter Feed",
        "url": "https://nitter.poast.org/IPL",
    },
]

# keywords that suggest tickets are going live
KEYWORDS = [
    "ticket",
    "book now",
    "booking",
    "go live",
    "on sale",
    "available now",
    "buy now",
    "chinnaswamy",
    "april 24",
]

STATE_FILE = "rcb_alert_state.json"

# ─────────────────────────────────────────
#  HELPERS
# ─────────────────────────────────────────

def load_state():
    if os.path.exists(STATE_FILE):
        with open(STATE_FILE, "r") as f:
            return json.load(f)
    return {}


def save_state(state):
    with open(STATE_FILE, "w") as f:
        json.dump(state, f)


def send_telegram(message):
    url = f"https://api.telegram.org/bot{TELEGRAM_BOT_TOKEN}/sendMessage"
    payload = {
        "chat_id": TELEGRAM_CHAT_ID,
        "text": message,
        "parse_mode": "HTML",
    }
    try:
        resp = requests.post(url, json=payload, timeout=10)
        if resp.status_code == 200:
            print(f"[{now()}] ✅ Telegram alert sent!")
        else:
            print(f"[{now()}] ❌ Telegram error: {resp.text}")
    except Exception as e:
        print(f"[{now()}] ❌ Telegram exception: {e}")


def now():
    return datetime.now().strftime("%Y-%m-%d %H:%M:%S")


def fetch_page(url):
    headers = {
        "User-Agent": (
            "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) "
            "AppleWebKit/537.36 (KHTML, like Gecko) "
            "Chrome/120.0.0.0 Safari/537.36"
        )
    }
    try:
        resp = requests.get(url, headers=headers, timeout=15)
        return resp.text.lower()
    except Exception as e:
        print(f"[{now()}] ⚠️  Could not fetch {url}: {e}")
        return None


def get_hash(text):
    return hashlib.md5(text.encode()).hexdigest()


def contains_keywords(text):
    found = [kw for kw in KEYWORDS if kw in text]
    return found


# ─────────────────────────────────────────
#  MAIN LOOP
# ─────────────────────────────────────────

def main():
    print(f"[{now()}] 🚀 RCB Ticket Alert started. Checking every {CHECK_INTERVAL_SECONDS // 60} minutes.")
    send_telegram("🏏 <b>RCB Ticket Alert is now running!</b>\n\nI'll notify you the moment any ticket booking announcement is detected.\n\n🔍 Monitoring RCB website + Twitter feeds.")

    state = load_state()

    while True:
        for source in SOURCES:
            name = source["name"]
            url  = source["url"]

            print(f"[{now()}] 🔍 Checking: {name}")
            content = fetch_page(url)

            if content is None:
                continue

            current_hash = get_hash(content)
            prev_hash    = state.get(name)

            # first run — just save hash, don't alert
            if prev_hash is None:
                state[name] = current_hash
                save_state(state)
                print(f"[{now()}] 📌 First run — saved baseline for: {name}")
                continue

            if current_hash != prev_hash:
                print(f"[{now()}] 🔔 Change detected on: {name}")
                matched = contains_keywords(content)

                if matched:
                    alert_msg = (
                        f"🚨 <b>RCB TICKET ALERT!</b>\n\n"
                        f"📍 Source: <b>{name}</b>\n"
                        f"🔗 URL: {url}\n\n"
                        f"🔑 Keywords found: <b>{', '.join(matched)}</b>\n\n"
                        f"⏰ Detected at: {now()}\n\n"
                        f"👉 Open the RCB app or royalchallengers.com/tickets NOW!"
                    )
                    send_telegram(alert_msg)
                else:
                    print(f"[{now()}] ℹ️  Page changed but no ticket keywords found. Skipping alert.")

                state[name] = current_hash
                save_state(state)

            else:
                print(f"[{now()}] ✓ No change: {name}")

        print(f"[{now()}] 💤 Sleeping for {CHECK_INTERVAL_SECONDS // 60} minutes...\n")
        time.sleep(CHECK_INTERVAL_SECONDS)


if __name__ == "__main__":
    main()
