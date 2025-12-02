using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    internal class Program {
        
        static bool eldontes(string sz) {
            for (int len = 1; len <= sz.Length / 2; len++) {
                if (sz.Length % len == 0)
                {
                    string kerSeq = sz.Substring(0, len);
                    string ismetelt = "";
                    for (int j = 0; j < sz.Length / len; j++) {
                        ismetelt += kerSeq;
                    }
                    if (ismetelt == sz) {
                        return true;
                    }
                }
            }
            return false;
        }

        static double osszeg = 0;
        static void Bekeres(double kezdes, double veg) {
            for (double i = kezdes; i <= veg; i++) {
                if (eldontes(Convert.ToString(i)) == true) {
                    osszeg += i;
                    Console.WriteLine(i);
                } 

            }
        }
        
        static void Main(string[] args) {
            string input = "503950-597501,73731-100184,79705998-79873916,2927-3723,35155-50130,52-82,1139-1671,4338572-4506716,1991-2782,1314489-1387708,8810810-8984381,762581-829383,214957-358445,9947038-10058264,4848455367-4848568745,615004-637022,5827946-5911222,840544-1026063,19-46,372804-419902,486-681,815-1117,3928-5400,28219352-28336512,6200009-6404247,174-261,151131150-151188124,19323-26217,429923-458519,5151467682-5151580012,9354640427-9354772901,262-475,100251-151187,5407-9794,8484808500-8484902312,86-129,2-18";
            string[] tartomanyok = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (string t in tartomanyok) {
                string[] parts = t.Split('-');
                double kezdes = double.Parse(parts[0]);
                double veg = double.Parse(parts[1]);
                Bekeres(kezdes, veg);
            }

            Console.WriteLine(osszeg);
        }
    }
}
