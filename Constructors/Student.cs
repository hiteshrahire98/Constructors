using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Student
    {
        private int rollno;
        private long mobileno;
        private string name;

        public Student()
        {
            rollno = 11;
            mobileno = 8999840126L;
            name = "Hitesh";
           
        }

        public Student(int rollno,long mobileno,string name)
        {
            this.rollno = rollno;
            this.mobileno = mobileno;
            this.name = name;
        }

        public string GetValues()
        {
            return $"Rollno:{rollno}  MobileNo:{mobileno} Name:{name}";
        }

    }
}
