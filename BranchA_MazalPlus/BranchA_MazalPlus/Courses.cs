using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Courses1
    {
        private string id;
        private string courseName;
        private double nakaz;
        private char year;
        private char semester;
        private string blockingCourse;

        public Courses1()
        {
            id = null;
            courseName = null;
            nakaz = 0.0;
            year = ' ';
            semester = ' ';
            blockingCourse = null;
        }

        public Courses1(string ID, string name, double nz, char y, char s, string block)
        {
            id = ID;
            courseName = name;
            nakaz = nz;
            year = y;
            semester = s;
            blockingCourse = block;
        }
    }
}

