using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsStoreApp_DataBinding
{
    public class EmployeeList
    {
        public ObservableCollection<Employee> emp = new ObservableCollection<Employee>();

        public EmployeeList()
        {
            emp.Add(new Employee("1", "Shan", 21, new DateTime(2014, 02, 06)));
            emp.Add(new Employee("2", "Khurram", 18, new DateTime(2015, 01, 01)));
            emp.Add(new Employee("3", "Saba", 25, new DateTime(2011, 03, 08)));
            emp.Add(new Employee("4", "Shuja", 31, new DateTime(2000, 08, 01)));
            emp.Add(new Employee("5", "Ali", 19, new DateTime(2010, 09, 02)));
            emp.Add(new Employee("6", "Junaid", 18, new DateTime(2012, 02, 06)));
        }

        public ObservableCollection<Employee> GetList()
        {
            return emp;
        }
    }
}
