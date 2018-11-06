using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Быки_и_коровы
{
   public class Bulls_and_Cows
    {
        int bulls, cows;
        char[] enigma;//загаданное число
        Random rand = new Random();
        
        static void Swap<T>(ref T a, ref T b)
        {
            var t = a; a = b; b = t;
        }

        public Bulls_and_Cows()
        {
            enigma = Enumerable.Range(0, 10).Select(x => (char)('0' + x)).ToArray();
        }

        internal string Step(string query)
        {
            if (query.Length == 4 &&
                query.All(ch => char.IsDigit(ch)) &&
                query.GroupBy(x => x).Count() == 4)
            {
                bulls = 0; cows = 0;
                for (int i = 0; i < 4; i++)
                    if (enigma[i] == query[i])
                        bulls++;
                    else
                    if (enigma.Take(4).Contains(query[i]))
                        cows++;
                return $"Быки - {bulls}, Kоровы - {cows}";
            }
            else
            {
                return "Введите четыре разные цифры: ";
            }
        }

        internal bool IsGameOver() => bulls == 4;//если bulls = 4 значит игра закончилась 
        
        public void NewGame()
        {
            for (int i = 0; i < 4; i++)
                {
                    Swap(ref enigma[i], ref enigma[rand.Next(i, 10)]);
                }
            Console.WriteLine(enigma);
        }      
    }
}
