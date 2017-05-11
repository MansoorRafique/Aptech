using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsStoreApp_DataBinding
{
    public class Employee
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public DateTime EmpJoiningDate { get; set; }

        public Employee(string empID, string empName, int empAge, DateTime empJoiningDate)
        {
            EmpID = empID;
            EmpName = empName;
            EmpAge = empAge;
            EmpJoiningDate = empJoiningDate;
        }

        public override string ToString()
        {
            return "EmpID: " + EmpID + ", " + "EmpName: " + EmpName + ", " + "EmpAge: " + EmpAge + ", " + "EmpJoining: " + EmpJoiningDate.ToString("d");
        }

    }
}
