using System;

namespace BankingAPPConsole_TylerWard
{
    class Program
    {
        
        static void Main(string[] args)
       
        {
            
            Account acct = new Account() {
                acctNumber = 0,
                acctName = "",
                acctType = "",
                acctEmail = "",
                acctBalance = 0,
                acctIsActive = true,
        
            };
        
            #region Menu
            Console.WriteLine("1.) Create an Account");
            Console.WriteLine("2.) Withdrawal");
            Console.WriteLine("3.) Deposit");
            Console.WriteLine("4.) Check Balance");
            Console.WriteLine("5.) Get Details");
            #endregion

            #region While Loop
            bool activeAcct = true;

            while(activeAcct) {

                int selection = Convert.ToInt32(Console.ReadLine());

                switch(selection){

                     case 1:
                        Console.WriteLine("Create an Account!");
                        Console.WriteLine("Add your Name:");
                      acct.acctName = Console.ReadLine();
                       Console.WriteLine("Do you want a Checking or Savings account?");
                      acct.acctType = Console.ReadLine();
                       Console.WriteLine("Add what your account number will be: ");
                      acct.acctNumber = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine("What is your account balance? ");
                     acct.acctBalance = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("What is your email? ");
                     acct.acctEmail = Console.ReadLine();
                     break;
                    case 2: 
                        Console.WriteLine("Balance before Withdrawal $" + acct.acctBalance);
                        Console.WriteLine("How much do you want to withdrawal?");
                        int w_amount = Convert.ToInt32(Console.ReadLine());
                        acct.Withdraw(w_amount);
                        Console.WriteLine("You now have $" + acct.acctBalance + " in your account");
                        break;

                    case 3:
                        Console.WriteLine("Balance before Deposit $" + acct.acctBalance);
                        Console.WriteLine("How much do you want to desposit?");
                        int d_amount = Convert.ToInt32(Console.ReadLine());
                        acct.Deposit(d_amount);
                        Console.WriteLine("You now have $" + acct.acctBalance + " in your account");
                        break;
                    
                    case 4:
                        Console.WriteLine("Your Account Balance is: $" + acct.acctBalance);
                     break;

                     case 5:
                        Console.WriteLine("These are the Account Details: ");
                        acct.getAccountDetails();

                        break;

                    default:
                        Console.WriteLine("Sorry this input is incorrect.");
                        activeAcct = false;
                    break;

                }
            }
            #endregion


        }
      
        
        
      
    }
}
