using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5
{
    class Program
    {
        public static string getString()
        {
            string str = Console.ReadLine();
            return str;
        }
        public static int getInt()
        {
            string str = getString();
            return Int32.Parse(str);
        }
        static void Main(string[] args)
        {
            Console.Write("enter x：");
            int x = getInt();
            Console.Write("enter y：");
            int y = getInt();
            Chess chess = new Chess(x, y);
            // chess.disPlayChessBoard();
            chess.knightTour();

            Console.ReadLine();
        }
    }
}
