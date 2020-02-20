using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public class Person
    {
        public Person(int id,

                         string name,

                         string surname,

                         string phone)

        {

            Id = id;

            Name = name;

            Surname = surname;

            Phone = phone;

        }

       
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

    }

}