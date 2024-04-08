using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04._2024.model
{
    internal class Student
    {
        private static int Count = 0;
        private int Id;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Count++;
             
            public static bool CheckName(string name)
            {
                return
            }
        }
    }
}
