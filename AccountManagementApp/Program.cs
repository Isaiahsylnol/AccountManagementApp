using System;

namespace ConsoleApp1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Account per1 = new Account("Nolan", 214, 400.85);
            Account per2 = new Account("Smith", 56, 200.21);
            Console.WriteLine(per1.toString());

            per1.deposit(200);
            Console.WriteLine("================================================\n");
            Console.WriteLine(per1.toString());

            per1.withdraw(300);
            Console.WriteLine("================================================\n");
            Console.WriteLine(per1.toString());
            Console.WriteLine(per2.toString());

            per1.transfer(per2, 200);
            Console.WriteLine("================================================\n");
            Console.WriteLine(per1.toString());
            Console.WriteLine(per2.toString());

            Console.WriteLine("================================================\n");
            Stocks blackberry = new Stocks(42, "Blackberry", 12.00); 
            
            Console.Read();
        }
    }
}
