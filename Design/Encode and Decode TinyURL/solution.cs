public class Codec {
    Dictionary<string, string> dict;
    string validChars;

    public Codec(){
        dict = new Dictionary<string, string>();
        validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    }

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        int lettersRamaining = 6;
        StringBuilder sb = new StringBuilder();
        while(lettersRamaining > 0){
            char rand = validChars[Random.Shared.Next(validChars.Length)];
            sb.Append(rand);
            lettersRamaining--;
        }
        string retString = "http://tinyurl.com/" + sb.ToString();
        dict[longUrl] = retString;

        return retString;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string retString = "";
        foreach(KeyValuePair<string, string> kvp in dict){
            if(kvp.Value == shortUrl)
                return kvp.Key;
        }
        return retString;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));
