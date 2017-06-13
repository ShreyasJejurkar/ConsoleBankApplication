using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleBankApplication
{
    public class CoreDetails
    {
        double account_number = 232313132;
        public string _fullName;
        private double _phoneNumber;
        private string _address;
        private string _email;
        private string _password;
        private double _accountNumber;
        private double _balance = 100;


        public string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Name cannot be null");
                }
                else
                {
                    this._fullName = value;
                }
            }
        }

        public double PhoneNumber
        {
            get
            {
                return this._phoneNumber;
            }

            set
            {
                if (value == 00 || value.ToString().Count() < 10)
                {
                    throw new Exception("Phone number is invalid");
                }
                else
                {
                    this._phoneNumber = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this._email;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Email is invalid");
                }
                else
                {
                    this._email = value;
                }
            }
        }


        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Address cannot be null");
                }
                else
                {
                    this._address = value;
                }
            }
        }

        public double AccountNumber
        {
            get
            {
                return this.account_number;
            }
            set
            {
                account_number++;
                this._accountNumber = account_number;
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("passowrd cannot be null");
                }
                else
                {
                    this._password = value;

                }
            }
        }


        /*
         * Following method for new registration 
         */
        public void NewAccountRegistration()       
        {
            try
            {
                Console.WriteLine("Please fill following form for new registration");
                Console.Write("Name - ");
                FullName = Console.ReadLine();
                Console.Write("Address - ");
                Address = Console.ReadLine();
                Console.Write("Phone number - ");
                PhoneNumber = double.Parse(Console.ReadLine());
                Console.Write("Email - ");
                Email = Console.ReadLine();
                Console.Write("Enter the password for your account");
                Password = Console.ReadLine();
                Console.WriteLine("Account created sucessfully.");
                Console.WriteLine("Your account number is " + AccountNumber);
                Console.WriteLine();

            }
            catch (Exception t)
            {
                Console.WriteLine(t.Message.ToString());
            }
        }

        public void CheckAccountDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Following are the account details");
            Console.WriteLine("Account number - " + AccountNumber);
            Console.WriteLine("Account holder name - " + FullName);
            Console.WriteLine("Address - " + Address);
            Console.WriteLine("Email - " + Email);
            Console.WriteLine("Phone number - " + PhoneNumber);
            Console.WriteLine("Balance - " + _balance);
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Your current balance is " + _balance);
            Console.WriteLine("Enter the amount to withdraw");
            int value = int.Parse(Console.ReadLine());
            if (value > _balance)
            {
                Console.WriteLine("Your current balance is not enough. Current balance is " + _balance);
            }
            else
            {
                _balance = _balance - value;
                Console.WriteLine("Transaction done sucessfully");
                Console.WriteLine("Your current balance is " + _balance);
            }
        }

        public void SaveMoney()
        {
            Console.WriteLine("Your current balance is " + _balance);
            Console.WriteLine("Enter the amount to save");
            int value = int.Parse(Console.ReadLine());
            _balance = _balance + value;
            Console.WriteLine("Saving done sucessfully");
            Console.WriteLine("Your current balance is " + _balance);
        }

        public void AccountSettings()
        {
            int userChoice = 0;
            string pass, newPassFirst, newPassSecond, newName;
            do
            {
                Console.WriteLine("Select from following option");
                Console.WriteLine("1. Change your password");
                Console.WriteLine("2. Edit your account holder name");
                Console.WriteLine("3. Exit settings.");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        /*
                         * Before editing sensetive info we are making user to enter its old password.
                         */ 
                        Console.WriteLine("Enter your old password first");
                        pass = Console.ReadLine();
                        if (pass == Password)
                        {
                            Console.WriteLine("Enter the new password");
                            newPassFirst = Console.ReadLine();
                            Console.WriteLine("Enter the new password again to confirm it");
                            newPassSecond = Console.ReadLine();
                            if (newPassFirst == newPassSecond)
                            {
                                Password = newPassSecond;
                                Console.WriteLine("The new password has been set");
                            }
                            else
                            {
                                Console.WriteLine("Password doesn't match");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry.The old password is incorrect");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the password of your account before accessing sensetive info");
                        pass = Console.ReadLine();
                        if (pass == Password)
                        {
                            Console.WriteLine("Enter the new account holder name");
                            newName = Console.ReadLine();
                            FullName = newName;
                            Console.WriteLine("The account holder name has been changed successfully");
                        }
                        else
                        {
                            Console.WriteLine("Sorry the password is incorrect. Try again later");
                        }
                        break;

                    case 3:
                        return;
                    default:
                        Console.WriteLine("Sorry. You have entered wrong choice. Please try again");
                        break;
                }
            } while (true);
        }
    }
}
