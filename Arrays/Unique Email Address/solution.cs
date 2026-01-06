public class Solution {
    public int NumUniqueEmails(string[] emails) {
        StringBuilder sb = new StringBuilder();
        List<string> mailList = new List<string>();
        bool gotPlus = false;
        bool isDomain = false;

        foreach(string email in emails){
            foreach(char character in email){
                if(character == '@'){
                    gotPlus = false;
                    isDomain = true;
                    sb.Append(character);
                }
                if(character == '+'){
                    gotPlus = true;
                    continue;
                }
                if(gotPlus)
                    continue;
                if(!isDomain){
                    if(character == '.')
                        continue;
                    else
                        sb.Append(character);
                }
                else{
                    sb.Append(character);
                }
            }
            isDomain = false;
            if(!mailList.Contains(sb.ToString())){
                mailList.Add(sb.ToString());
            }
            sb = new StringBuilder();
        }
        return mailList.Count;
    }
}
