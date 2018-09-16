using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5
{
    class StackX
    {
        private int top;
        private Grid[] grd;
        private readonly int MAX_SIZE = 200;
        public StackX()
        {
            grd = new Grid[MAX_SIZE];
            top = -1;
        }
        public void push(Grid elem)
        {
            grd[++top] = elem;
        }
        public Grid peek()
        {
            return grd[top];
        }
        public Grid pop()
        {
            return grd[top--];
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
    }
}
