using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPJECT4NEW.Classes
{
    public class Secretary : PersonStuff
    {
        public Secretary()
        {
        }

        public Secretary(string id) : base(id)
        {

        }

        public double AVG(int []grades, int size)
        {
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                sum += grades[i];
            }
            return (float) sum / size;
        }

        public bool checkIfTrue(bool flag)
        {
            return flag;
        }
        

    }
}
