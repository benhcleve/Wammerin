using System;
using System.Numerics;

public static class Styling
{
    public static void Indent(int count)
    {
        string indent = " ";
        Console.Write(indent.PadLeft(count));
    }

    public static void CooordinatesText(Vector3 coordinates)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(coordinates.ToString());
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void DirectionText(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void ControlsText(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

}

