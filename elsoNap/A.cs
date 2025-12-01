using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    internal class Program {
        static int starting = 50;
        static int counter = 0;
        static void szamolas(char jel, int szam) {
            if (jel == 'L') {
                starting = (starting - szam + 100) % 100;
            } else {
                starting = (starting + szam) % 100;
            }
            if (starting == 0) {
                counter++;
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
            string sor = " ";
            while (!string.IsNullOrEmpty(sor)) {
                sor = Console.ReadLine();
                numbers.Add(sor);
            }
            for (int i = 0; i < numbers.Count-1; i++) {
                Beolvasas(numbers[i]);
            }
            Console.WriteLine(counter);
        }
    }
}
