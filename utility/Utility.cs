using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace utility
{
    public class Utility
    {
        public string RandomDigit(int size, bool character, bool num, bool lowerCase, bool IsRandom)
        {
            StringBuilder builder = new StringBuilder();
            StringBuilder builder2 = new StringBuilder();
            StringBuilder result = new StringBuilder();
            Random random = new Random();
            char ch;


            for (int i = 0; i < size; i++)
            {
                if (character)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    if ((lowerCase) && (i % 2 == 0))
                    {
                        ch = Convert.ToChar(ch.ToString().ToLower());
                    }
                }
                ch = new char();
                if (i % 3 == 0 || !character)
                {
                    ch = Convert.ToChar(random.Next(0, 9).ToString());
                    builder.Append(ch);
                    ch = Convert.ToChar(random.Next(0, 9).ToString());
                    builder.Append(ch);
                }
                else
                {
                    builder.Append(ch);
                }
                result = builder;
            }

            string tmp = builder.ToString();
            if (IsRandom)
            {
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(tmp[random.Next(tmp.Length)]);
                    try
                    {
                        tmp = tmp.Replace(ch.ToString(), "");
                    }
                    catch (Exception)
                    {
                    }
                    builder2.Append(ch);
                }
                tmp = builder2.ToString();
                result = builder2;
            }

            if (tmp.Length < size)
            {
                for (int i = 0; i < (size - tmp.Length) + 1; i++)
                {
                    ch = Convert.ToChar(random.Next(0, 9).ToString());
                    result.Append(ch);
                }
            }
            else if (tmp.Length > size)
            {
                result.Remove(size, tmp.Length - size);
            }
            return builder.ToString() + " | " + builder2.ToString() + " | " + result.ToString();
        }
    }
}



