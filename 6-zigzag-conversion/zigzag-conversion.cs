public class Solution
    {
        
        public string Convert(string s, int numRows)
        {
            int first_row_count = -2;
            for (int i = 0; i < numRows; i++)
            {
                if (numRows == 1)
                {
                    first_row_count = 1;
                    break;
                }
                first_row_count += 2;
            }

            int temp_count = first_row_count;
            int others_upper_count = first_row_count;
            int others_down_count = first_row_count;

            string Rows = "";
            for (int i = 0, j = 1, count_middle = 0; ; i += temp_count)
            {
                if (s.Length > i && Rows.Length != s.Length) { Rows += (s[i]); }
                if (i >= s.Length)
                {
                    j += 1;
                    i = j - 1;

                    if (Rows.Length == s.Length)
                    {
                        break;
                    }
                    else
                    {
                        Rows += (s[i]);
                    }


                    others_upper_count -= 2;
                    others_down_count = first_row_count - others_upper_count;
                    count_middle = 2;                
                    
                }

                if (j == numRows || numRows == 1)
                {
                    temp_count = first_row_count;
                }
                else if (j != numRows && j != 1 && count_middle % 2 != 0)
                {
                    temp_count = others_down_count;
                }
                else if (j != numRows && j != 1 && count_middle % 2 == 0)
                {
                    temp_count = others_upper_count;
                }

                count_middle += 1;

            }
            return Rows;
        }
    }