using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olimpic2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            using(StreamReader sr = new StreamReader(@"INPUT.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
                sr.Close();
            }
            string[] mas=text.Split(new char[]{' '});
            int sum=0;

            for (int i = 0; i < mas.Length; i++)
            {
                sum += int.Parse(mas[i]);
            }
            sum = sum / 27;
            using(StreamWriter sw =new StreamWriter(@"OUTPUT.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(sum);
                sw.Close();
            }
        }
    }
}
