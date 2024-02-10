public class Solution
    {
        public int Reverse(int x)
        {
            string s = x.ToString();
            List<char> number = new List<char>();
            foreach (var a in s)
            {
                if (a != '-')
                {
                    number.Add(a);
                }
            }
            if (s.Contains('-'))
            {
                number.Add('-');
            }
            number.Reverse();
            if (number[0] == '0'&&number.Count>1)
            {
                number.Remove(number[0]);
            }

            s = "";
            foreach (var some in number)
            {

                s += some;

            }
            bool result=Int32.TryParse(s,out x);
            if (result)
            {
                return x;
            }
            else
            {
                return 0;
            }

        }
    }