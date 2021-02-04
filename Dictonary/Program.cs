using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> isim = new MyDictonary<string>();
            isim.Add("Deha");
            Console.WriteLine(isim.Lenght);
            isim.Add("Nazım");
            Console.WriteLine(isim.Lenght);
            foreach (var isimler in isim.Items)
            {
                Console.WriteLine(isimler);
            }
        }
	

	
    }
}
