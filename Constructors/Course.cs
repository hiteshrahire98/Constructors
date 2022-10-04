using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Course
    {
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
    }
}
