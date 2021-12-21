using System;

namespace devam
{
    class Program
    {

        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;
            int result = 0;
            var choose=0;
            while (true)
            {
                Console.WriteLine("Birinci ededi edin");
                first = int.Parse(Console.ReadLine());

                Console.WriteLine("Ikinci ededi edin");
                second = int.Parse(Console.ReadLine());

                Console.WriteLine("Daxil edin");
                Console.WriteLine("1---Topla");
                Console.WriteLine("2---Cix");
                Console.WriteLine("3---Vur");
                Console.WriteLine("4---Bol");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1) Plus(first, second, ref result);
                else if (choose == 2) Cix(first, second, ref result);
                else if (choose == 3) Vur(first, second, ref result);
                else if (choose == 4) Bol(first, second, ref result);
                else
                {
                    Console.WriteLine("Duzgun daxil edin");

                }
            }
           
        }

        static void Plus(int first,int second,ref int result)
        {
            result = first + second;
            Console.WriteLine(result);
        }
        static void Cix(int first, int second, ref int result)
        {
            result = first - second;
            Console.WriteLine(result);
        }

        static void Vur(int first, int second, ref int result)
        {
            result = first * second;
            Console.WriteLine(result);
        }
        static void Bol(int first, int second, ref int result)
        {
            if(second is 0)
            {
                Console.WriteLine("sifira bolmek omaz");

                return;
            }
            result = first / second;
            Console.WriteLine(result);
        }

    }
}
