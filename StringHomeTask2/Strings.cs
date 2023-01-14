using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomeTask2
{
    internal class Strings
    {

        internal static string TimeDifference(string time1, string time2)
        {
            int h3;
            int m3;
            int s3;

            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            if (s2 >= s1)
                s3 = s2 - s1;
            else
                s3 = 60 - (s1 - s2);


            if (m1 <= m2)
                m3 = m2 - m1;
            else
                m3 = 60 - (m1 - m2);


            if (h2 >= h1)
                h3 = h2 - h1;

            else
            {
                if (h1 - h2 > 12)
                    h3 = 24 - (h1 - h2);
                else
                    h3 = 12 - (h1 - h2);
            }
            if (h3 < 10)
                h3 = 0 + h3;

            if (m3 < 10)
                m3 = 0 + m3;

            if (s3 < 10)
                s3 = int.Parse($"0{s3}");

              

            return $"0{h3}:0{m3}:0{s3}";
        }
    }
}
