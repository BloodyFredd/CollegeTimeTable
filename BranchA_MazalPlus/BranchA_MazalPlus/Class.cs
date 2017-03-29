using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Class
    {
        private string date;
        private string classNum;
        private string type;
        private int capacity;
        private bool holiday;
        private bool [] hours;
        public Class()
        {
            date = null;
            classNum = null;
            type = null;
            capacity = 0;
            holiday = false;
            hours = new bool[13];
            for(int i = 0; i < 13; i++)
            {
                hours[i] = false;
            }
        }
        public Class(string day, string num, string typeOfClass, int cap, bool hol, bool[] hour)
        {
            date = day;
            classNum = num;
            type = typeOfClass;
            capacity = cap;
            holiday = hol;
            hours = new bool[13];
            for (int i = 0; i < 13; i++)
            {
                hours[i] = hour[i];
            }
        }
    }
}
