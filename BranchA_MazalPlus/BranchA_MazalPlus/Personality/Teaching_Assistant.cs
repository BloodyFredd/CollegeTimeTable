using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Teaching_Assistant: Person
    {
        private string type;
        private int[] courseID;
        private string office;
        private string receptionDay;
        private string receptionStart;
        private string receptionEnd;

        public Teaching_Assistant() : base()
        {

            this.type = "Teaching_Assistant";
            this.courseID = new int[10];
            for (int i = 0; i < courseID.Length; i++)
            {
                this.courseID[i] = -1;
            }
            this.office = null;
            this.receptionDay = null;
            this.receptionStart = null;
            this.receptionEnd = null;
        }

        public Teaching_Assistant(string ID, string FIRname, string LAname, string TELE, string EMA, string PASS, int[] courses, string off, string day, string start, string end) : base(ID, FIRname,LAname, TELE, EMA, PASS, "Teaching_Assistant")
        {
            this.type = "Teaching_Assistant";
            this.courseID = new int[courses.Length];
            for (int i = 0; i < courseID.Length; i++)
            {
                this.courseID[i] = courses[i];
            }
            this.office = off;
            this.receptionDay = day;
            this.receptionStart = start;
            this.receptionEnd = end;

        }
    }
}
