using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Student
    {
        /*   private int rollno;
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
          */

        private int rollno, sub1, sub2, sub3, total;
        private string name;
        private double percentage;
        public Student(int rollno, string name, int sub1, int sub2, int sub3)
        {
            this.rollno = rollno; // this keyword refers to data member
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }

        public void Calculate()
        {
            total = sub1 + sub2 + sub3;
            percentage = (double)total / 3;
        }

        public override string ToString()
        {
            return $"Roll No={rollno}  Name={name} Total= {total}  Percentage={percentage}";
        }
    }
}
