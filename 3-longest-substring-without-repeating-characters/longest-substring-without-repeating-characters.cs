public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                string substring = "";
                List<string> string_list = new List<string> { };
                List<char> chars = new List<char> { };
                for(int i=0; i < s.Length; i++)
                {
                    if (substring.Contains(s[i]))
                    {
                        string_list.Add(substring);
                        substring = substring.Substring(substring.IndexOf(s[i])+1)+s[i];
                   
                    }
                    else if(s==" " || (!substring.Contains(s[i])&&i==s.Length-1))
                    {
                        substring += s[i];
                        string_list.Add(substring);
                        break;
                    }
                    else
                    {
                        substring += s[i];
                    }
                   
                }
                string temp = "";
                foreach(var str in string_list)
                {
                    if(str.Length > temp.Length)
                    {
                        temp = str;
                    }
                }
                Console.WriteLine(temp);
                return temp.Length;
            }
        }