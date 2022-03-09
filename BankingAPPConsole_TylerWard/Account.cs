using System; 

#region Properties

class Account {
    public int acctNumber { get; set; }
    public string acctName { get; set; }
    public string acctEmail { get; set; }
    public string acctType { get; set; }
    public bool acctIsActive { get; set; }
    public int acctBalance { get; set; }



#endregion
#region Methods
    public double Withdraw (int w_amount) {
        acctBalance = acctBalance - w_amount;
        return acctBalance;
    }
    public double Deposit (int d_amount) {
        acctBalance = acctBalance + d_amount;
        return acctBalance;
    }
    public void getAccountDetails(){
        Console.WriteLine("Account Number: " + acctNumber);
        Console.WriteLine("Account Name: "+ acctName);
        Console.WriteLine("Account Email: "+ acctEmail);
        Console.WriteLine("Account Type: " + acctType);
        Console.WriteLine("Account Balance: "+ acctBalance);
     
    }
#endregion


}


