using System;

public class Grass : Ground
{
    public override void visual()
    { Console.BackgroundColor = ConsoleColor.DarkGreen; Console.ForegroundColor = ConsoleColor.Green; Console.Write("~”~"); Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black; }
}
