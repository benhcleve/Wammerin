using System;

public class StoneWall : WorldObject
{
    public override string name { get { return "Stone Wall"; } }
    public override string shortDescription { get { return "a cold stone wall"; } }
    public override void visual() { Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("█▄█"); Console.ForegroundColor = ConsoleColor.White; }


}
