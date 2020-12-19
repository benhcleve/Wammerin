using System;
using System.Drawing;

namespace Wammerin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(200, 50); //Sets size of console screen
            Console.BufferHeight = Console.WindowHeight; //Rids height scrollbar
            Console.BufferWidth = Console.WindowWidth; //Rids width scrollbar
            Console.CursorVisible = false;
            GameManager.Instance.Start();
        }


    }
}
