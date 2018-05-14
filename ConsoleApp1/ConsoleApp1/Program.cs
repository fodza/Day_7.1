using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ReizTabula();
            Console.ReadLine();
        }

        static void ReizTabula()

        {
            Console.WriteLine("Ievadiet skaitli 1 ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i );

            }
            
        }

    }
}
