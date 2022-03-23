using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Employee_Management {
 public class EmployeeDetails {
    SqlConnection con = new SqlConnection(@"server=LAPTOP-7FIGL6S6;database=employeeDB;integrated security = true");
    public string empName { get; set; }
    public int empNo { get; set; }
    public int empSalary { get; set; }
    public string empPosition { get; set; }
    public bool empIsActive { get; set; }
    public int empId { get; set; }

    public string addEmployee(EmployeeDetails newEmployee)
    {
        
        SqlCommand cmd_addEmployee = new SqlCommand("insert into employeeDetails2 values(@empName,@empPosition,@empNo,@empSalary,@empIsActive)",con);
        
        cmd_addEmployee.Parameters.AddWithValue("@empName",newEmployee.empName);
        cmd_addEmployee.Parameters.AddWithValue("@empPosition",newEmployee.empPosition);
        cmd_addEmployee.Parameters.AddWithValue("@empNo",newEmployee.empNo);
        cmd_addEmployee.Parameters.AddWithValue("@empSalary",newEmployee.empSalary);
        cmd_addEmployee.Parameters.AddWithValue("@empIsActive",newEmployee.empIsActive);
        
        try
        {
            con.Open();
            cmd_addEmployee.ExecuteNonQuery();                    
        }
        catch(SqlException es)
        {
            System.Console.WriteLine(es.Message);
        }
        finally
        {
            con.Close();
        }
        return "Employee Added Successfully";

    }
    public string editEmployee(EmployeeDetails newEmployee)
    {
            SqlCommand cmd_updateEmployee = new SqlCommand("update employeeDetails2 set empNo = @newEmpNo, empName = @newEmpName, empPosition = @newEmpPosition, empSalary = @newEmpSalary where empId = @empId",con);
            cmd_updateEmployee.Parameters.AddWithValue("@newEmpName",newEmployee.empName);
            cmd_updateEmployee.Parameters.AddWithValue("@newEmpNo",newEmployee.empNo);
            cmd_updateEmployee.Parameters.AddWithValue("@newEmpPosition",newEmployee.empPosition);
            cmd_updateEmployee.Parameters.AddWithValue("@newEmpSalary",newEmployee.empSalary);
            cmd_updateEmployee.Parameters.AddWithValue("@empId",newEmployee.empId);

            try
            {
                con.Open();
                cmd_updateEmployee.ExecuteNonQuery();
            }
            catch (System.Exception es)
            {
                System.Console.WriteLine(es.Message);
            }
            finally
            {
                con.Close();
            }
            return "Employee Updated";
            
    }
    public string deleteEmployee(int empId)
    {
        SqlCommand cmd_deleteEmployee = new SqlCommand("delete from employeeDetails2 where empId=@empId",con);
        cmd_deleteEmployee.Parameters.AddWithValue("@empId",empId);
        try
        {
            con.Open();
            cmd_deleteEmployee.ExecuteNonQuery();
        }
        catch (System.Exception es)
        {
            
            System.Console.WriteLine(es.Message);
        }
        finally
        {
            con.Close();
        }
        return "Employee Deleted";
    }
    
    public EmployeeDetails getEmployeeById(int id)
    {
        EmployeeDetails emp = null;
        SqlCommand cmd_search = new SqlCommand("select * from employeeDetails2 where empId = @empID",con);
        cmd_search.Parameters.AddWithValue("@empId",id);
        SqlDataReader read;
        try
            {
            con.Open();
            read = cmd_search.ExecuteReader();

            if(read.Read())
            {
                emp = new EmployeeDetails();
                emp.empId = id;
                emp.empName =Convert.ToString(read[1]);
                emp.empPosition =Convert.ToString(read[2]);
                emp.empNo = Convert.ToInt32(read[3]);
                emp.empSalary = Convert.ToInt32(read[4]);
                emp.empIsActive = Convert.ToBoolean(read[5]);

                return emp;
            }
            else {
                System.Console.WriteLine("Sorry Employee Was Not Found, Please Re-Enter ID");
            }

        }
        catch (System.Exception es)
        {
            
            System.Console.WriteLine(es.Message);
        }
        finally
        {
            con.Close();
        }
    return emp;
    }
    public List<EmployeeDetails> getEmployeeList() {

        SqlCommand cmd_allEmployees = new SqlCommand("select * from employeeDetails2", con);
        SqlDataReader readEmployees = null;
        List<EmployeeDetails> list_EmployeeDB = new List<EmployeeDetails>();


        try {
            con.Open();
            readEmployees = cmd_allEmployees.ExecuteReader();
            
            while(readEmployees.Read()) {
                list_EmployeeDB.Add(new EmployeeDetails() {
                    empId = Convert.ToInt32(readEmployees[0]),
                    empName = readEmployees[1].ToString(),
                    empPosition = readEmployees[2].ToString(),
                    empNo = Convert.ToInt32(readEmployees[3]),
                    empSalary = Convert.ToInt32(readEmployees[4]),
                    empIsActive = Convert.ToBoolean(readEmployees[5]),
                });
            }
        }
        catch (SqlException es) {
            throw new Exception(es.Message);
        }
        finally {
            readEmployees.Close();
            con.Close();
        }
        return list_EmployeeDB;
    }
 }
}



