using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGMap
{
    internal class Program
    {
        static char[,] map = new char[,]     {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        static int row;
        static int column;

        static void Main(string[] args)
        {
            column = map.GetLength(1);
            row = map.GetLength(0);
            DrawMap();
            Console.WriteLine();
            Console.WriteLine();
            DrawMap(2);
            Console.WriteLine();
            Console.ReadKey(true);
        }

        static void DrawMap()
        {
            
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void DrawMap(int scale)
        {
            int borderSize = column * scale;
            for(int a = 0; a < 1; a++)
            {
                Console.Write("+");
                for(int b = 0; b < borderSize; b++)
                {
                    Console.Write("-");
                }
                Console.Write("+");
            }
            //Console.WriteLine();
            Console.WriteLine();
            for (int h = 0; h < row; h++)
            {
                //Console.Write("-");
                for (int i = 0; i < scale; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < column; j++)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            Console.Write(map[h, j]);
                        }
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
            for (int a = 0; a < 1; a++)
            {
                Console.Write("+");
                for(int b = 0; b < borderSize; b++)
                {
                    Console.Write("-");
                }
                Console.Write("+");
            }
        }
    }
}
