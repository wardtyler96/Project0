using System;

namespace BankingAPPConsole_TylerWard
{
    class Program
    {
        
        static void Main(string[] args)
       
        {
          
            #region Menu
            Console.WriteLine("1.) Create an Account");
            Console.WriteLine("2.) Withdrawal");
            Console.WriteLine("3.) Deposit");
            Console.WriteLine("4.) Check Balance");
            Console.WriteLine("5.) Get Details");
            Console.WriteLine("6.) Exit");
            #endregion

            #region While Loop
            bool activeAcct = true;

            while(activeAcct) {

                int selection = Convert.ToInt32(Console.ReadLine());

                switch(selection){
                    #region 1.)Create Account
                     case 1:
                     Account acct = new Account ();
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

                        acct.acctIsActive = true;
                        
                        acct.SaveObject();
                     break;
                     #endregion 
                    //#region 2.)Withdrawal
                
                    // case 2: 
                    // try {
                    //     Console.WriteLine("Balance before Withdrawal $" + acct.acctBalance);
                    //     Console.WriteLine("How much do you want to withdrawal?");

                    //     int w_amount = Convert.ToInt32(Console.ReadLine());
                    //     acct.Withdraw(w_amount);
                    // }
                    // catch (Exception es ) {
                    //     Console.WriteLine(es.Message);
                    // }
                    // finally {
                    //     Console.WriteLine("You now have $" + acct.acctBalance + " in your account");
                        
                    // }
                    // break;
                      
                    // #endregion
                    // #region 3.)Deposit
                    // case 3:
                    //     Console.WriteLine("Balance before Deposit $" + acct.acctBalance);
                    //     Console.WriteLine("How much do you want to desposit?");
                    //     int d_amount = Convert.ToInt32(Console.ReadLine());
                    //     acct.Deposit(d_amount);
                    //     Console.WriteLine("You now have $" + acct.acctBalance + " in your account");
                    //     break;
                    // #endregion
                    // #region 4.)Check Balance
                    // case 4:
                    //     Console.WriteLine("Your Account Balance is: $" + acct.acctBalance);
                    //  break;
                   //  #endregion
                    #region 5.)Account Details
                     case 5:
                        Account accObj = new Account();
                        Console.WriteLine("Enter the account number you want the details of: ");
                        int account = Convert.ToInt32(Console.ReadLine());
                        accObj = accObj.GetObject(account);
                        Console.WriteLine(accObj.acctType);
                        Console.WriteLine(accObj.acctEmail);
                        Console.WriteLine(accObj.acctBalance);
                        Console.WriteLine(accObj.acctIsActive);

                        break;
                    #endregion
                    #region 6.) Exit
                    default:
                        Console.WriteLine("Have a great day!");
                        activeAcct = false;
                    break;
                    #endregion

                }
            }
            #endregion


        }
      
        
        
      
    }
}
