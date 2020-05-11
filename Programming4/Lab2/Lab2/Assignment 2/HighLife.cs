using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayGameOfLife
{
    class HighLife : ConwayGameOfLife
    {
        public override bool CellShouldLive(bool livingCell, int neighbourCount)
        {

            if (neighbourCount == 3 || neighbourCount == 6)
                return true;

            if (livingCell && (neighbourCount == 2 || neighbourCount == 3))
                return true;

            // dead cell
            return false;
        }
    }
}
