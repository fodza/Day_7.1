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

            //ReizTabula();
            //Zvaigznite();
            Saskaititajs();
            Console.ReadLine();
        }

        static void ReizTabula()

        {
            Console.WriteLine("Ievadiet skaitli 1 ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);

            }


        }

        static void Zvaigznite()
        {
            string zvaignzne = "";
            for (int i = 1; i < 4; i++)
            {
                zvaignzne = zvaignzne + "*";
                Console.WriteLine(zvaignzne);
            }

        }

        static void Saskaititajs()

        {
            Console.WriteLine("Ievadiet skaitli ");

            string ievade = Console.ReadLine();
            int skaitlis = 0;
            int stopskaitlis = Convert.ToInt16(ievade);
            

            for (int i = 0; i <= stopskaitlis; i++)
            {
                int OldVertiba = skaitlis; // 1.x ejot caur vertiba vel ir nulle 
                skaitlis = skaitlis + i;
                Console.WriteLine(OldVertiba + "+" + i + "=" + skaitlis);

            }

          
            
        }

    }
}
