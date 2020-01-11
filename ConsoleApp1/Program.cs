using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe("200ml","Vaso",4,4);
            
            Console.WriteLine(cafe.EntregarCafe());
            Console.Read();
        }
    }
}
