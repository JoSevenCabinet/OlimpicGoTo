using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olimpic4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strs;
            string text;
            using (StreamReader sw = new StreamReader(@"INPUT.txt", System.Text.Encoding.Default))
            {
                text = sw.ReadToEnd();
                sw.Close();
            }
            int[] mas = new int[text.Length];
            strs = text.Split(new char[] { ' ' });
            for (int i = 0; i < strs.Length; i++)
            {
                mas[i] = int.Parse(strs[i]);
            }
            int p1 = 0;
            int p2 = 0;
            mas[2] = mas[2] * 2;
            if (mas[0] >= mas[1])
            {
                p1 = mas[0];
                p2 = mas[1];
            }
            else
            {
                p1 = mas[1];
                p2 = mas[0];
            }
            while ((p1 + mas[2] <= 70) && (mas[2] > 0))
            {
                p1 += 1;
                mas[2] -= 1;
            }
            if ((p2 + mas[2]) > 38) p2 = p2 + mas[2];
            else p1 = p1 + mas[2];
            int k = p1;
            double sum = 0;
            for (int i = 0; i < 2; i++)
            {

                switch (k)
                {
                    case 0:
                        break;
                    case 1:
                        sum += 22;
                        break;

                    case 2:
                        sum += 44;
                        break;
                    case 3:
                        sum += 64.33;
                        break;
                    case 4:
                        sum += 84.67;
                        break;
                    case 5:
                        sum += 105;
                        break;
                    case 6:
                        sum += 124;
                        break;
                    case 7:
                        sum += 143;
                        break;
                    case 8:
                        sum += 162;
                        break;
                    case 9:
                        sum += 181;
                        break;
                    case 10:
                        sum += 200;
                        break;
                    case 11:
                        sum += 218;
                        break;
                    case 12:
                        sum += 236;
                        break;
                    case 13:
                        sum += 254;
                        break;
                    case 14:
                        sum += 272;
                        break;
                    case 15:
                        sum += 290;
                        break;
                    case 16:
                        sum += 308;
                        break;
                    case 17:
                        sum += 326;
                        break;
                    case 18:
                        sum += 344;
                        break;
                    case 19:
                        sum += 362;
                        break;
                    case 20:
                        sum += 380;
                        break;
                    case 21:
                        sum += 392.13;
                        break;
                    case 22:
                        sum += 404.25;
                        break;
                    case 23:
                        sum += 416.38;
                        break;
                    case 24:
                        sum += 428.5;
                        break;
                    case 25:
                        sum += 440.63;
                        break;
                    case 26:
                        sum += 452.75;
                        break;
                    case 27:
                        sum += 464.88;
                        break;
                    case 28:
                        sum += 477;
                        break;
                    case 29:
                        sum += 489.13;
                        break;
                    case 30:
                        sum += 501.25;
                        break;
                    case 31:
                        sum += 513.38;
                        break;
                    case 32:
                        sum += 525.5;
                        break;
                    case 33:
                        sum += 537.63;
                        break;
                    case 34:
                        sum += 549.75;
                        break;
                    case 35:
                        sum += 561.88;
                        break;
                    case 36:
                        sum += 574;
                        break;
                    case 37:
                        sum += 586.13;
                        break;
                    case 38:
                        sum += 598.25;
                        break;
                    case 39:
                        sum += 610.38;
                        break;
                    case 40:
                        sum += 622.5;
                        break;
                    case 41:
                        sum += 634.63;
                        break;
                    case 42:
                        sum += 646.75;
                        break;
                    case 43:
                        sum += 658.88;
                        break;
                    case 44:
                        sum += 671;
                        break;
                    case 45:
                        sum += 683.13;
                        break;
                    case 46:
                        sum += 695.25;
                        break;
                    case 47:
                        sum += 707.38;
                        break;
                    case 48:
                        sum += 719.5;
                        break;
                    case 49:
                        sum += 731.63;
                        break;
                    case 50:
                        sum += 743.75;
                        break;
                    case 51:
                        sum += 755.88;
                        break;
                    case 52:
                        sum += 768;
                        break;
                    case 53:
                        sum += 780.13;
                        break;
                    case 54:
                        sum += 792.25;
                        break;
                    case 55:
                        sum += 804.38;
                        break;
                    case 56:
                        sum += 816.5;
                        break;
                    case 57:
                        sum += 828.63;
                        break;
                    case 58:
                        sum += 840.75;
                        break;
                    case 59:
                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 69:
                    case 70:
                        sum += 850;
                        break;
                    default:
                        if (k > 70) sum += 850 + ((k - 70) * 15.71);
                        break;
                }

                k = p2;

            }
            if (p1 > 0) sum += 10;
            if (p2 > 0) sum += 10;

            using (StreamWriter sw = new StreamWriter(@"OUTPUT.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(sum);
                sw.Close();
            }
        }
    }
}
