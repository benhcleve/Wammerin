using System;
using System.Numerics;
using static Styling;

public class VisualDisplay
{

    private static VisualDisplay instance = new VisualDisplay();
    public static VisualDisplay Instance
    {
        get { return instance; }
    }



    public void GridView(int xSize, int zSize, Ground defaultGround) //Shows a visual representation of player surroundings
    {
        //Draws the top of the border
        Indent((Console.WindowWidth / 2) - (xSize * 3));
        Console.Write("╔");
        string horizontalBar = new string('═', ((xSize * 2) * 3) + 3);
        Console.Write(horizontalBar);
        Console.WriteLine("╗");
        //----------------------

        for (int z = zSize; z >= -zSize; z--) //Loop through z axis
            for (int x = -xSize; x <= xSize; x++) //within z axis loop, loop through all x axis
            {
                var isWorldObject = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates.ContainsKey(new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z));
                var isGround = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].groundBycoordinates.ContainsKey(new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z));
                Action objectVisual = () => WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates[new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z)].visual();
                Action groundVisual = () => WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].groundBycoordinates[new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z)].visual();

                if (x == 0 && z == 0)
                {
                    Console.Write("YOU");

                }
                else if (isWorldObject) //There is a world object there
                {
                    if (x == xSize) //If the last line
                    {
                        objectVisual();
                        Console.WriteLine("║");
                    }
                    else if (x == -xSize) //If the first line
                    {
                        Indent((Console.WindowWidth / 2) - (xSize * 3));
                        Console.Write("║");
                        objectVisual();
                    }
                    else
                    {
                        objectVisual();
                    }
                }
                else if (isGround) //There is ground
                {
                    if (x == xSize) //If the last line
                    {
                        groundVisual();
                        Console.WriteLine("║");
                    }
                    else if (x == -xSize) //If the first line
                    {
                        Indent((Console.WindowWidth / 2) - (xSize * 3));
                        Console.Write("║");
                        groundVisual();
                    }
                    else
                    {
                        groundVisual();
                    }
                }
                else //Nothing is there
                {
                    if (x == xSize) //If the last line
                    {
                        defaultGround.visual();
                        Console.WriteLine("║");
                    }
                    else if (x == -xSize) //If the first line
                    {
                        Indent((Console.WindowWidth / 2) - (xSize * 3));
                        Console.Write("║");
                        defaultGround.visual();
                    }
                    else
                    {
                        defaultGround.visual();
                    }
                }
            }
        //Draws the bottom of the border
        Indent((Console.WindowWidth / 2) - (xSize * 3));
        Console.Write("╚");
        Console.Write(horizontalBar);
        Console.WriteLine("╝");
        //----------------------

    }
}
