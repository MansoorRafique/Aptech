using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsStoreApp_DataBinding2
{
    public class Person : Employee
    {
        private int id;
        private string fName;
        private string lName;
        private int age;
        private string email;
        private Uri source;

        public Uri Source
        {
            get { return source; }
            set { source = value; }
        }

       

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
    

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
       

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
     

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
