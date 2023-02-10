using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många **minuter** lång är låten?");
            int minut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hur många **sekunder** lång är låten?"); 
            int sekund = Convert.ToInt32(Console.ReadLine());
            int tid = minut * 100 + sekund;

            if (tid >= 245 && tid <= 420)
                Console.WriteLine("Din låt får spelas");
            else
                Console.WriteLine("Din låt får inte spelas");



        }
    }
}
