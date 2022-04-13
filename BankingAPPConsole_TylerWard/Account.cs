using System; 
using System.Xml.Serialization;
using System.IO;

#region Properties
[Serializable]
public class Account {
    public int acctNumber { get; set; }
    public string acctName { get; set; }
    public string acctEmail { get; set; }
    public string acctType { get; set; }
    public bool acctIsActive { get; set; }
    public int acctBalance { get; set; }



#endregion
#region Methods
    public double Withdraw (int w_amount) {
        if(w_amount<0) {
            throw new Exception("Please use a Positive Integer.");
        }
       else if(w_amount > acctBalance) {
            throw new Exception("Insufficient Funds");
        }
        else if( w_amount == 0) {
            throw new Exception("Please enter a number greater than 0");
        }
        acctBalance = acctBalance - w_amount;
        return acctBalance;
        
    }


    public double Deposit (int d_amount) {
        acctBalance = acctBalance + d_amount;
        return acctBalance;
    } 

    public void SaveObject( ) {
        FileStream file = new FileStream (acctNumber+".xml",FileMode.Create,FileAccess.Write);
        XmlSerializer serial = new XmlSerializer (typeof(Account));
        serial.Serialize(file,this);
        file.Close();
        Console.WriteLine("Object has been saved");
    }
    public Account GetObject(int accountNumber) {
        FileStream file = new FileStream (accountNumber+".xml",FileMode.Open,FileAccess.Read);
        XmlSerializer serial = new XmlSerializer(typeof(Account));
        Account details = (Account) serial.Deserialize(file);
        file.Close();
        return details;

    }
    // public void getAccountDetails(){
    //     Console.WriteLine("Account Number: " + acctNumber);
    //     Console.WriteLine("Account Name: "+ acctName);
    //     Console.WriteLine("Account Email: "+ acctEmail);
    //     Console.WriteLine("Account Type: " + acctType);
    //     Console.WriteLine("Account Balance: "+ acctBalance);
     
    // }
#endregion


}


