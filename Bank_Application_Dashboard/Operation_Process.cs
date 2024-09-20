using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application_Dashboard
{
    public class Operation_Process
    {

        long current_Balance = 704;

        public void operation_Process()
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome: " + userName);

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Number:");
                    long acc_no = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** Enter a number, That was not a number, please try again ***");
              
                }

            }

              
                bool continueOperation = true;
                while (continueOperation)
                {
                    Console.WriteLine("Please select a option that you want to perform here:");

                    Console.WriteLine(" 1.Current Balance \n 2.Deposit  \n 3.Withdraw \n 4.Exit");

                    int option = Convert.ToInt16(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Your Current Balance: " + current_Balance);
                            break;

                        case 2:
                            Console.Write("Enter the amount that you want to deposit: ");
                            long deposit = Convert.ToInt64(Console.ReadLine());

                            if (deposit != 0)//100
                            {
                                current_Balance = deposit + current_Balance;
                                Console.WriteLine("Amount Deposited Successfully");
                                Console.WriteLine("Updated Balance: " + current_Balance);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Deposited Amount");
                            }

                            break;

                        case 3:
                            Console.Write("Enter the amount that you want to withdraw: ");
                            int withdraw = Convert.ToInt16(Console.ReadLine());

                            if (withdraw < current_Balance)
                            {
                                current_Balance = current_Balance - withdraw;
                                Console.WriteLine("Amount Withdraw Successfully");
                                Console.WriteLine("Current Balance: " + current_Balance);
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Balance");
                            }

                            break;
                        case 4:
                            Console.WriteLine("Thank you");
                            continueOperation = false;
                            break;

                        default:
                            Console.WriteLine("oops! Please select a correct option");
                            break;
                    }
                }
            }
        }
    }

