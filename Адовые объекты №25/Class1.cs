using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адовые_объекты__25
{
    class Location
    {
        public int x, y;
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void MoveXY(int newx, int newy)
        {
            x = newx;
            y = newy;
        }

    }
}



