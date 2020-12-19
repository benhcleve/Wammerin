using System;

public class Dirt : Ground
{
    public override void visual() { Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black; Console.Write("░▒░"); Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; }
}
