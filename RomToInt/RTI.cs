using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt.RomToInt
{
    public class RTI
    {

    }

    public class InToRo2
    {
        public String intToRoman(int num)
        {
            string ans="";
            try
            {
                //Arrays of Roman Numbers
                if(num<1000)
                {
                    String[] m = { "", "M", "MM", "MMM" };
                    String[] c = { "",  "C",  "CC",  "CCC",  "CD",
                       "D", "DC", "DCC", "DCCC", "CM" };
                    String[] x = { "",  "X",  "XX",  "XXX",  "XL",
                       "L", "LX", "LXX", "LXXX", "XC" };
                    String[] i = { "",  "I",  "II",  "III",  "IV",
                       "V", "VI", "VII", "VIII", "IX" };

                    // Divides and assigns to responsible variable
                    String thousands = m[num / 1000];
                    String hundreds = c[(num % 1000) / 100];
                    String tens = x[(num % 100) / 10];
                    String ones = i[num % 10];

                    ans = thousands + hundreds + tens + ones;
                    return ans;
                }
                
                
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }

            return ans;
        }
    }

    public class RoToIn
    {
        //Returns Roman Number
        public virtual int value(char r)
        {
            if (r == 'I')
                return 1;
            if (r == 'V')
                return 5;
            if (r == 'X')
                return 10;
            if (r == 'L')
                return 50;
            if (r == 'C')
                return 100;
            if (r == 'D')
                return 500;
            if (r == 'M')
                return 1000;
            return -1;
        }

        // Finds decimal value of a
        // given romal numeral
        public virtual int romanToDecimal(string str)
        {
            int res = 0;

            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // Getting value of symbol s[i]
                    int s1 = value(str[i]);

                    // Getting value of symbol s[i+1]
                    if (i + 1 < str.Length)
                    {
                        int s2 = value(str[i + 1]);

                        // Comparing both values
                        if (s1 >= s2)
                        {
                            res = res + s1;
                        }
                        else
                        {
                            res = res + s2 - s1;
                            i++;
                        }
                    }
                    else
                    {
                        res = res + s1;
                        i++;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // Initialize result
            

            return res;
        }

    }
}
