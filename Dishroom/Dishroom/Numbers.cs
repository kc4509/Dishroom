using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishroom
{
    //Number class
    internal class Numbers
    {
        protected static Random rnd = new Random();

        //generates a random number
        public static int genRandom (int low, int high)
        {
            int temp = rnd.Next(low, high);
            return temp;
        }
    }
}
