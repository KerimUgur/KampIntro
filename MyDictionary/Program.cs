using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> sayilar = new MyDictionary<int>();
            sayilar.Add(35);
            sayilar.Add(39);

            Console.WriteLine(sayilar.Lenght);

            foreach (var sayi in sayilar.Numbers )
            {
                Console.WriteLine(sayi);
            }

            
        }
    }
}
