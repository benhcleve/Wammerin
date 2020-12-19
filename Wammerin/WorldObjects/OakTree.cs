using System;

public class OakTree : WorldObject
{
    public override string name { get { return "Oak Tree"; } }
    public override string shortDescription { get { return "an oak tree"; } }
    public override void visual()
    {
        Console.ForegroundColor = ConsoleColor.Green; Console.Write("█"); Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("▄"); Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green; Console.Write("█"); Console.ForegroundColor = ConsoleColor.White;
    }
}
