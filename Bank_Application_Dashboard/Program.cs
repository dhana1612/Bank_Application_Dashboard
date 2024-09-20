
using Bank_Application_Dashboard;
using System;

namespace BankApplication
{
    class BankApplication
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("\n\tWelcome to Abc Bank SYSTEM");
            Console.WriteLine("----------------------------------------");

            Operation_Process op = new Operation_Process();

            op.operation_Process();

        }
    }
}