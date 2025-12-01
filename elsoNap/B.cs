using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    internal class Program {
        static int starting = 50;
        static int counter = 0;
        static void szamolas(char jel, int szam) {
            
            if (jel == 'L') {
                for (int i = 1; i <= szam; i++) {
                    int act = ((starting - i) %100+ 100) % 100;
                    if(act == 0) {
                        counter++;
                    }
                    
                }
                starting = (starting - szam + 100) % 100;
            } else {
                for (int i = 1; i <= szam; i++) {
                    int act = ((starting + i)%100) % 100;
                    if (act == 0) {
                        counter++;
                    }
                }
                
                starting = (starting + szam) % 100;
            }
            
        }

        static void Beolvasas(string data) {
            char jel = data[0];
            string szamok = "";
            for (int i = 1; i < data.Length; i++) {
                szamok += data[i];
            }
            int nums = Convert.ToInt32(szamok);
            szamolas(jel, nums);
        }

        static void Main(string[] args) {
            List<string> numbers = new List<string>();

            string sor = Console.ReadLine();   
            while (!string.IsNullOrEmpty(sor))
            {
                numbers.Add(sor);
                sor = Console.ReadLine();      
            }
            for (int i = 0; i < numbers.Count; i++) {
                Beolvasas(numbers[i]);
            }
            Console.WriteLine(counter);
        }
    }
}
