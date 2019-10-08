using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodi_pari_dispari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primi cento numeri pari:");
            NumeriPari();
            Console.WriteLine("\n");
            Console.WriteLine("Primi cento numeri dispari:");
            NumeriDispari();


            //Task.Factory.StartNew(NumeriPari);
            //Task.Factory.StartNew(NumeriDispari);


            Console.ReadLine();
        }

        public static void NumeriPari()
        {
            for (int i = 0; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void NumeriDispari()
        {

            for (int i = 0; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

        }

    }
}
