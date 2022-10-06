using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Course
    {
        /* 
        private int id;
        private string name;
        private float fees;

        public Course(int id, string name, float fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
        }

        public override string ToString()  //ToString method is used to display string representation of an object
        {
            return $" Course Id {id} name {name} Fees {fees}";
        }
        */

        private int id;
        private string name;
        private float fees;
        // property to assign value & return from data member

        public int Id // Id is property name
        {
            get { return id; } // return value from data member
            set { id = value; } // value is built in keyword to assign value
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        public override string ToString()
        {
            return $" Course Id {id} name {name} Fees {fees}";
        }

    }
}
