using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_4
{
    public class Rectengle : Shape
    {
        public override int CalculateArea(int high, int asos)
        {
            return (high * asos) / 2;
        }
    }
}
