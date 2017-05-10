/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package employee.details;
import java.util.Scanner;

public class EmployeeDetails {

         int Emplyee_ID;
         String Employee_Name;
         String Designation;
         int Basic_Salary_;
         int Sales;
         int Commision;
         int Total_Salary;

   
    public static void main(String[] args) {
        EmployeeDetails emp = new EmployeeDetails();
        Scanner input = new Scanner(System.in);
        System.out.println("******Employee-Details******");
        System.out.println("Enter Employee ID : ");
        emp.Emplyee_ID = input.nextInt();
        System.out.println("Enter Employee Name : ");
        emp.Employee_Name = input.next();
        System.out.println("Enter Employee Designation : ");
        emp.Designation = input.next();
        System.out.println("Enter Employee Basic Salary : ");
        emp.Basic_Salary_ = input.nextInt();
        System.out.println("Enter Employee Sales : ");
        emp.Sales = input.nextInt();
        System.out.println("Employee ID is :" + emp.Emplyee_ID);
        System.out.println("Employee Name is :" + emp.Employee_Name);
        System.out.println("Employee Designation is :" + emp.Designation);
        System.out.println("Employee Basic Salary is :" + emp.Basic_Salary_);
        System.out.println("Employee ID is :" + emp.Sales);
        if(emp.Sales >= 10000 && emp.Sales >= 8000)
        {
            emp.Commision = emp.Basic_Salary_* 30/100;
        }
        
        if(emp.Sales >= 6000)
        {
            emp.Commision = emp.Basic_Salary_* 20/100;
        }
        
        if(emp.Sales >= 4000)
        {
            emp.Commision = emp.Basic_Salary_* 10/100;
        }
        
        emp.Total_Salary = emp.Basic_Salary_ + emp.Commision;
        
        System.out.println("The Commision of Employee is : " + emp.Commision);
        System.out.println("The Total Salary of Employee is : " + emp.Total_Salary);
    }
    
}
