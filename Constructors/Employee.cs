using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Employee
    {
         private int empid,empage;
        private string empname,empaddress;

        public Employee()
        {
            this.empid = empid;
            this.empage = empage;
            this.empname = empname;
            this.empaddress = empaddress;

        }

        public Employee(int empid,int empage, string empname,string empaddress)
        { 
            this.empid = empid;
            this.empage = empage;
            this.empname = empname;
            this.empaddress = empaddress;

        }

        public string GetValues()
        {
            return $"Employee id:{empid} Employee age:{empage} Employee name:{empname} Employee address:{empaddress}";
        }

    }
}
