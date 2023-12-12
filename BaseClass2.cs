using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba4
{
    interface Interface_2
    {
        double Minimum();
    }
    class BaseClass2
    {
        protected double[] arr;
        public BaseClass2(double[] arr)
        {
            this.arr = arr;
        }
        public double Maximum()
        {
            double max = 0.0;
            bool start = false;
            for (int i = 0;i < arr.Length;i++)
            {
                if (max < arr[i] || start == false)
                {
                    max = arr[i];
                    start = true;
                }
            }
            return max;
        }
        public double[] DisplayArray()
        {
            return arr;
        }
    }
}
