using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Быки_и_коровы
{
    public class Program
    {
        static void Main()//игровой цикл
        {
            var bc = new Bulls_and_Cows();
            do
            {
                Console.Clear();
                Console.WriteLine("Новая игра");
                bc.NewGame();
                do
                {
                    var query = Console.ReadLine();//ввод
                    var MyGuess = bc.Step(query);
                    Console.WriteLine(MyGuess);
                }
                while (!bc.IsGameOver());//пока не конец игры
                Console.WriteLine("Конец игры \n y/n ?");

            }   
            while (Console.ReadKey().KeyChar == 'y');
        }
        
    }
}