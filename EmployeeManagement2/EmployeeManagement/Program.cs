using System;



namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manObj = new Manager();
                manObj.empNo = 3;
                manObj.empName = "Nikhil";
                manObj.empSalary = 10000;
                manObj.empIsPermanent = true;

            HR hrObj = new HR();
                hrObj.empNo = 2;
                hrObj.empName = "Shelby";
                hrObj.empSalary = 10000;
                hrObj.empIsPermanent = true;

            Developer devObj = new Developer();
                devObj.empNo = 1;
                devObj.empName = "Tyler";
                devObj.empSalary = 10000;
                devObj.empIsPermanent = true;

            int percent = 0;
            Console.WriteLine("Show Manager Bonus: " + manObj.getBonus(percent) );
            Console.WriteLine("Show HR Bonus: " + hrObj.getBonus(percent));
            Console.WriteLine("Show Developer Bonus: " + devObj.getBonus(percent));

            Console.WriteLine(manObj.WhoIam());
            Console.WriteLine(hrObj.WhoIam());
            Console.WriteLine(devObj.WhoIam());
        }
    }
}      
    