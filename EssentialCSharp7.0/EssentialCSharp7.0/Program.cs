using System;
using System.Collections;
using System.Collections.Generic;

namespace EssentialCSharp7._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Sketch();
        }

        public void Sketch()
        {
            //Stack path = new Stack();
            Stack<Cell> path = new Stack<Cell>();
            Stack path1 = new Stack();
            Cell currentPosition;
            ConsoleKeyInfo key;

            do
            {
                key = Move();
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                        if (path.Count >= 1)
                        {
                            //currentPosition = (Cell)path.Pop();
                            currentPosition = path.Pop();
                            Console.SetCursorPosition(currentPosition.X, currentPosition.Y);
                            Undo();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.RightArrow:
                        currentPosition = new Cell(Console.CursorLeft, Console.CursorTop);
                        path.Push(currentPosition);
                        break;
                    default:
                        Console.Beep();
                        break;
                }
            }
            while (key.Key != ConsoleKey.X);
        }

        private ConsoleKeyInfo Move()
        {
            return Console.ReadKey();
        }

        private void Undo()
        {

        }
    }

    public struct Cell
    {
        public int X { get; }
        public int Y { get; }
        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
