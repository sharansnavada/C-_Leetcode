public class Solution {
    public string AddBinary(string a, string b) {
        int carry = 0;string s = "";int n =0;
        if(a.Length >= b.Length){
            n = b.Length - 1;
        }
        else{
            string temp = b;
            b = a;
            a = temp;
            n = b.Length -1 ;
        }

        for(int i = a.Length - 1; i>= 0; i--){
            if(n >= 0){
                if(int.Parse(a[i].ToString()) == 0 && int.Parse(b[n].ToString()) == 0){
                    int sum = carry + 0;
                    s += sum.ToString();
                    carry = 0;
                }
                else if(int.Parse(a[i].ToString()) + int.Parse(b[n].ToString()) == 1){
                    if(carry == 1){
                        int sum = 0;
                        carry = 1;
                        s += sum.ToString();
                    }
                    else{
                        s += "1";
                    }
                }
                else if(int.Parse(a[i].ToString()) + int.Parse(b[n].ToString()) == 2){
                    if(carry == 1){
                        int sum = 1;
                        carry = 1;
                        s += sum.ToString();
                    }
                    else{
                        int sum = 0;
                        carry = 1;
                        s += sum.ToString();
                    }
                }
                n--;
            }

            else{
                if(int.Parse(a[i].ToString()) == 0 && carry == 0){
                    s += "0";
                }
                else if(int.Parse(a[i].ToString()) + carry == 1){
                    s += "1";
                    carry = 0;
                }
                else if(int.Parse(a[i].ToString()) + carry == 2){
                    s += "0";
                    carry = 1;
                }
            }
        }

        if(carry == 1){
            s += "1";
        }

        char[] cArr = s.ToCharArray();
        Array.Reverse(cArr);
        string str = new string(cArr); 
        return str;
    }
}
