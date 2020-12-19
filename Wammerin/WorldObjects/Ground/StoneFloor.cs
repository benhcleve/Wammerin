using System;

public class StoneFloor : Ground
{
    public override void visual() { Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black; Console.Write(" ¬ "); Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; }
}
