using System;
using System.Numerics;
using static Styling;

public class Player
{
    private static Player instance = new Player();
    public static Player Instance { get { return instance; } }

    public string name;
    public string currentArea;
    public Vector3 coordinates = new Vector3(0f, 0f, 0f);

    //Stats
    public int eyeSight = 20;

    public void DisplayPlayerInfo()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(new string('╩', Console.WindowWidth));
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Name: " + name);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(" ║ ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Location: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Player.Instance.currentArea);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(" ║ ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Coordinates: ");
        Styling.CooordinatesText(Player.instance.coordinates);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(" ║ ");


        Console.WriteLine(new string('═', Console.WindowWidth));
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }
}
