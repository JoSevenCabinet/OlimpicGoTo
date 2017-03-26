using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olimpic
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string texts;

            using (StreamReader sr = new StreamReader(@"INPUT.TXT", System.Text.Encoding.Default))
            {
                texts = sr.ReadLine();
                sr.Close();
            }
            int chislo;
            int chet = 0;
            chislo = int.Parse(texts);
            int n = 1;
            int n2 = 4;
            int kon = 0;
            while (kon==0)
            {
                for (int i=n; i < n2; i += 1)
                {
                    chet += 1;
                    if (i == chislo)
                    {
                        kon += 1;
                        break;
                        
                    }
                }
                n += 1;
                n2 += 1;
            }

            using (StreamWriter sw=new StreamWriter(@"OUTPUT.TXT", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(chet);
                sw.Close();
            }
        }
    }
}
