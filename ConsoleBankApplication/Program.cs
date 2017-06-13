using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleBankApplication
{
    class Program
    {
       public static void Main(string[] args)
       {
           // MAX USERS 100

           CoreDetails[] data = new CoreDetails[100];        // creating array (size 100) of objects of our core data class
           
            /*
             * initializing them with constructors 
             */

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new CoreDetails();
            }

            int userChoice = 0 , count = 0 , pass = 0;
            try
            {
                do
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Select from following option.");
                    Console.WriteLine("1. Log in.");
                    Console.WriteLine("2. Create a new account.");
                    Console.WriteLine("3. Administrative log in.");
                    Console.WriteLine("4. Exit.");
                    Console.WriteLine("=====================================");
                    userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Enter the Account number.");
                            double ACN = double.Parse(Console.ReadLine());
                            for (int i = 0; i < data.Length; i++)
                            {

                                /* Checking account number with all of the objects account number
                                 */
                                if (data[i].AccountNumber == ACN)
                                {
                                    Console.WriteLine("Enter the password for the account");
                                    string passw = Console.ReadLine();
                                    if (passw == data[i].Password)          //checking password with current ACN
                                    {
                                        Console.WriteLine("You have sucessfully logged in.");
                                        Console.Clear();
                                        Console.WriteLine("Welcome");
                                        do
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Select from following option");
                                            Console.WriteLine("1. Check account details.");
                                            Console.WriteLine("2. Withdraw money.");
                                            Console.WriteLine("3. Save money.");
                                            Console.WriteLine("4. Account settings.");
                                            Console.WriteLine("5. Exit.");
                                            userChoice = int.Parse(Console.ReadLine());
                                            switch (userChoice)
                                            {
                                                case 1:
                                                    data[i].CheckAccountDetails();
                                                    break;

                                                case 2:
                                                    data[i].WithdrawMoney();
                                                    break;

                                                case 3:
                                                    data[i].SaveMoney();
                                                    break;

                                                case 4:
                                                    data[i].AccountSettings();
                                                    break;

                                                case 5:
                                                    break;

                                                default:
                                                    Console.WriteLine("Sorry. You have entered wrong choice. Please try again");
                                                    break;
                                            }

                                        } while (userChoice != 5);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry. The password is incorrect");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry. That account doesnt exists.");
                                    break;
                                }
                            }
                            break;

                        case 2:
                            data[count].NewAccountRegistration();
                            count++;
                            break;

                        case 3:
                            Console.WriteLine("Enter the administrative account");
                            pass = int.Parse(Console.ReadLine());
                            if (pass == 00000)
                            {
                                Console.WriteLine("Total accounts in banks : " + count);

                                for (int i = 0; i < data.Length; i++)
                                {
                                    data[i].CheckAccountDetails();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Password is incorret");
                            }
                            break;

                        case 4:
                            break;

                        default:
                            Console.WriteLine("Sorry. You have entered wrong choice. Please try again");
                            break;

                    }
                } while (userChoice != 4);
            }
            catch (Exception error)
            {
                Console.WriteLine("Something went wrong. " + error.Message);
            }

        }

    }
}
