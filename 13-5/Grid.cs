using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5
{
    class Grid
    {
        public int x;
        public int y;
        public int z;
        public Grid(int z, int x, int y)
        {
            this.z = z;
            this.x = x;
            this.y = y;
        }
        public Grid getNextGrid(int f, Direction d)
        {
            return new Grid(f, this.x + d.x, this.y + d.y);
        }
    }
}
