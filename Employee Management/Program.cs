using System;
using System.Collections.Generic;


namespace Employee_Management
{
    class Program
    {
         static void Main(string[] args)
        {
            EmployeeDetails empDetails = new EmployeeDetails();
    

            bool login = true;
            bool isLoggedIn = false;

            if(isLoggedIn == false) {
                System.Console.WriteLine("Please Enter Your Username");
                string username = Console.ReadLine();
                System.Console.WriteLine("Please Enter Your Password");
                string password = Console.ReadLine();
                Login logObj = new Login();

              bool logInResult = logObj.LoginInfo(username,password);
                if(logInResult == false) {
                    System.Console.WriteLine("Login Invalid. Please Try Again.");
                }
                else {
                    isLoggedIn = true;
                
            while (login)
             {
             Console.WriteLine("---------The Employee Database---------");
            System.Console.WriteLine("1. Add A New Employee");
            System.Console.WriteLine("2. Employee List");
            System.Console.WriteLine("3. Search Employee By ID");
            System.Console.WriteLine("4. Edit Employee");
            System.Console.WriteLine("5. Delete Employee");
            System.Console.WriteLine("6. Exit");
              int choice = Convert.ToInt32(Console.ReadLine());


              switch (choice)
              {
                case 1:
                    #region  Add A New Employee 
                    EmployeeDetails newEmployee = new EmployeeDetails();
                    System.Console.WriteLine("Enter Employee Name");
                    newEmployee.empName = Console.ReadLine();
                    System.Console.WriteLine("Enter Employee Position");
                    newEmployee.empPosition = Console.ReadLine();
                    System.Console.WriteLine("Enter Employee Number");
                    newEmployee.empNo = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter Employee Salary");
                    newEmployee.empSalary = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Enter True If Employee Is Active, False If Not Active");
                    newEmployee.empIsActive = Convert.ToBoolean(Console.ReadLine());
                    System.Console.WriteLine(empDetails.addEmployee(newEmployee));
                break;
                    #endregion
                case 2:
                #region Employee List
                      Console.WriteLine("--------------Display List for Employees-----------");
                List<EmployeeDetails> list = empDetails.getEmployeeList();
                foreach(var item in list) {
                    System.Console.WriteLine("-----------------------");
                    Console.WriteLine("Employee ID: " + item.empId);
                    System.Console.WriteLine("Employee Name: " + item.empName);
                    System.Console.WriteLine("Employee No: " + item.empNo);
                    System.Console.WriteLine("Employee Position: " + item.empPosition);
                    System.Console.WriteLine("Employee Salary: " + item.empSalary);
                    System.Console.WriteLine("Employee Is Active: " + item.empIsActive);

                }
                #endregion
               
                break;
                    
                case 3:
                #region Employee ID Search
                  System.Console.WriteLine("Enter Employee Id To Search For An Employee");
                    int empId2 = Convert.ToInt32(Console.ReadLine());
                    EmployeeDetails emp = empDetails.getEmployeeById(empId2);
                    System.Console.WriteLine("Employee ID " + emp.empId);
                    System.Console.WriteLine("Employee Name " + emp.empName);
                    System.Console.WriteLine("Employee Position " + emp.empPosition);
                    System.Console.WriteLine("Employee Number " + emp.empNo);
                    System.Console.WriteLine("Employee Salary " + emp.empSalary);
                    System.Console.WriteLine("Employee Is Active " + emp.empIsActive);
                    
             
               
                #endregion
                    break;
                case 4:
                #region Edit Employee
                        System.Console.WriteLine("Enter Employee Name");
                string empName2 = Console.ReadLine();
                System.Console.WriteLine("Enter Employee Position");
                string empPosition2 = Console.ReadLine();
                System.Console.WriteLine("Enter Employee Number");
                int empNo2 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter Employee Salary");
                int empSalary2 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter True If Employee Is Active, Enter False If Employee Is Not Active");
                bool empIsActive2 = Convert.ToBoolean(Console.ReadLine());

                System.Console.WriteLine("Enter Employee Id");
                int id = Convert.ToInt32(Console.ReadLine());
                EmployeeDetails employeeEdit = new EmployeeDetails();
                employeeEdit.empId = id;
                employeeEdit.empName = empName2;
                employeeEdit.empPosition = empPosition2;
                employeeEdit.empNo = empNo2;
                employeeEdit.empSalary = empSalary2;
                employeeEdit.empIsActive = empIsActive2;
                
                System.Console.WriteLine(empDetails.editEmployee(employeeEdit));
                #endregion
                 
                    break;
                case 5:
                     #region Delete An Employee
                    System.Console.WriteLine("Enter Employee Id To Delete An Employee");
                    int empId = Convert.ToInt32(Console.ReadLine());

                   System.Console.WriteLine(empDetails.deleteEmployee(empId));
                     #endregion
                    break;
                case 6:
                 login = false;
                 isLoggedIn = false;
                    break;
                default:
                        System.Console.WriteLine("Please Enter A Choice On The Menu");
                        break;
              }
                
             }

            }

        }
        }
    }
}