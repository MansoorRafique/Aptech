using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WindowsStoreApp_DataBinding2
{
    public class PersonList
    {

        public ObservableCollection<Person> per = new ObservableCollection<Person>();

        public PersonList()
        {
            per.Add(new Person
            {
                Id = 1,
                FName = "Shan",
                LName = "Mushtaq",
                Age = 25,
                Email = "abc@yahoo.com",
                Source = new Uri("ms-appx:///Assets/1.jpg")
            });

            per.Add(new Person
            {
                Id = 2,
                FName = "Ammar",
                LName = "Ahmed",
                Age = 35,
                Email = "abc@yahoo.com",
                Source = new Uri("ms-appx:///Assets/2.jpg")
            });

            per.Add(new Person
            {
                Id = 3,
                FName = "Mehdi",
                LName = "Muzaffar",
                Age = 20,
                Email = "abc@yahoo.com",
                Source = new Uri("ms-appx:///Assets/3.jpg")
            });

            per.Add(new Person
            {
                Id = 4,
                FName = "Saba",
                LName = "Khan",
                Age = 27,
                Email = "abc@yahoo.com",
                Source = new Uri("ms-appx:///Assets/4.jpg")
            });

            per.Add(new Person
            {
                Id = 5,
                FName = "Farhan",
                LName = "Khan",
                Age = 20,
                Email = "abc@yahoo.com",
                Source = new Uri("ms-appx:///Assets/5.jpg")
            });

        }

        public ObservableCollection<Person> GetPersonList()
        {
            return per;
        }
    }
}
