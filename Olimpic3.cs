using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olimpic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo;
            using (StreamReader sr = new StreamReader(@"INPUT.txt", System.Text.Encoding.Default))
            {
                chislo = int.Parse(sr.ReadLine());
                sr.Close();
            }
                
            int str = 4;
            int nachalo=0;
            for (int i = str;  ; i++)
            {
                if (i < 10)
                {
                    nachalo += 1;
                }
                else if (i < 100)
                {
                    nachalo += 2;
                }
                else if (i < 1000)
                {
                    nachalo += 3;
                }
                else if (i < 10000)
                {
                    nachalo += 4;
                }
                if(nachalo == chislo)
                {
                    using (StreamWriter sw = new StreamWriter(@"OUTPUT.txt", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(i);
                        sw.Close();
                    }
                    break;
                }
            }
         

        }
    }
}
