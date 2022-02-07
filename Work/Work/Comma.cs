using System;
using System.Collections.Generic;
using System.Text;

namespace Work
{
    class Comma
    {
        public static string appendComma(double n)
        {
            string result = n.ToString();
            List<string> list = new List<string>();
            bool dotCheck = false;
            if (result.Contains('.'))
                dotCheck = true;

            int cnt = 0;
            for(int i= result.Length-1; i>=0; i--)
            {
                if (dotCheck && result[i] == '.')
                {
                    list.Insert(0, ".");
                    cnt = 0;
                    dotCheck = false;
                    continue;
                }
                if (cnt != 0 && cnt % 3 == 0 && !dotCheck)
                    list.Insert(0, ",");
                list.Insert(0, result[i].ToString());
                cnt++;
            }

            result = "";
            for(int i=0; i<list.Count; i++)
            {
                result += list[i];
            }

            return result;
        }

        public static double Round(double value)
        {
            int result=0;
            string s = value.ToString();

            if (s[s.Length - 1] >= 5)
            {
                return Math.Ceiling(value);
            }
            else
            {
                return Math.Truncate(value);
            }
        }
    }
}
