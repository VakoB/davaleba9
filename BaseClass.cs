using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba4
{
    interface Interface_1
    {
        int Perimeter();
    }
    class BaseClass
    {
        int side_1;
        int side_2;
        int side_3;
        public BaseClass(int side_1, int side_2, int side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }
        public double Fartobi()
        {
            return (side_1 * side_3)/2;
        }
    }

}
