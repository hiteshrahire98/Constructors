using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Department
    {
        private int deptid;
        private string deptname;
        private string location;

        public int Deptid
        { 
          get { return deptid; }
          set { deptid = value; }
        }

        public string Deptname
        {
            get { return deptname; }
            set { deptname = value; }
        }

        public int Location
        {
            get { return Location; }
            set { Location = value; }
        }

        public override string ToString()
        { 
           return $"Department Id:{deptid} Name:{deptname} Location:{location}";
        }
    }
}
