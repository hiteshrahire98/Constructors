using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Date
    {
        private int day, year;
        private string month;

        // using method assign value to the member
        // constructor - non parametric
        public Date()
        {
            day = 1;
            month = "Jan";
            year = 2022;
        }

        public Date(int day,int year,string month)
        { 
            this.day = day;
            this.year = year;
            this.month = month;
        }

        public string GetValues()
        {
            return $"Date: {day}/{month}/{year}";
        }

    }
}
