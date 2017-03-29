using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Lecturer : Person
    {
        private string type;
        private int[] courseID;
        private string office;
        private string receptionDay;
        private string receptionStart;
        private string receptionEnd;

        public Lecturer() : Person()
        {

            this.type = "Lecturer";
            this.courseID = new int[10];
            for (int i = 0; i < courseID.Length; i++)
            {
                this.courseID[i] = -1;
            }
            this.office = null;
            receptionDay = null;
            receptionStart = null;
            receptionEnd = null;
        }

        public Lecturer()
        {

        }
    }
}
