using System;
using System.Collections.Generic;
using System.Numerics;
using static Styling;


public class Exploration
{
    private static Exploration instance = new Exploration();
    public static Exploration Instance { get { return instance; } }

    public void ShowExploration()
    {
        Console.Clear();
        Player.Instance.DisplayPlayerInfo();
        Console.WriteLine("\t Back to Exploration.");
        ExplorationUI();
        GameManager.Instance.WaitForInput();
    }

    public void MoveNorth()
    {
        Console.Clear();
        if (ObjectNextToPlayer("North") != null)
        {
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You attempt to move north, but " + ObjectNextToPlayer("North").shortDescription + " is blocking the way.");
            ExplorationUI();
        }
        else
        {
            Console.Clear();
            Player.Instance.coordinates.Z++;
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You move north.");
            ExplorationUI();
        }
        GameManager.Instance.WaitForInput();
    }

    public void MoveSouth()
    {
        Console.Clear();
        if (ObjectNextToPlayer("South") != null)
        {
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You attempt to move south, but " + ObjectNextToPlayer("South").shortDescription + " is blocking the way.");
            ExplorationUI();
        }
        else
        {
            Console.Clear();
            Player.Instance.coordinates.Z--;
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You move south.");
            ExplorationUI();
        }
        GameManager.Instance.WaitForInput();
    }

    public void MoveEast()
    {
        Console.Clear();
        if (ObjectNextToPlayer("East") != null)
        {
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You attempt to move east, but " + ObjectNextToPlayer("East").shortDescription + " is blocking the way.");
            ExplorationUI();
        }
        else
        {
            Console.Clear();
            Player.Instance.coordinates.X++;
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You move east.");
            ExplorationUI();
        }
        GameManager.Instance.WaitForInput();
    }

    public void MoveWest()
    {
        Console.Clear();
        if (ObjectNextToPlayer("West") != null)
        {
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You attempt to move west, but " + ObjectNextToPlayer("West").shortDescription + " is blocking the way.");
            ExplorationUI();
        }
        else
        {
            Console.Clear();
            Player.Instance.coordinates.X--;
            Player.Instance.DisplayPlayerInfo();
            Console.WriteLine("\t You move west.");
            ExplorationUI();
        }
        GameManager.Instance.WaitForInput();
    }

    public void ExplorationUI()
    {
        Console.CursorTop = Console.WindowHeight - 25; //Sets the UI 25 rows from the bottom
        Console.WriteLine(new string('═', Console.WindowWidth));
        Console.WriteLine();

        VisualDisplay.Instance.GridView(5, 5, WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].defaultGround);

        //North
        Indent((Console.WindowWidth / 2) - 2); ControlsText("[W]");
        DirectionText("North: \n");
        if (ObjectNextToPlayer("North") != null)
        {

            Indent((Console.WindowWidth / 2) - 5); Console.Write(ObjectNextToPlayer("North").name);
            CooordinatesText(ObjectNextToPlayer("North").coordinates);
            Console.WriteLine();

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Indent((Console.WindowWidth / 2) - 5); Console.WriteLine("Nothing of interest.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //West and East Labels
        Indent((Console.WindowWidth / 2) - 30); ; ControlsText("[A]");
        DirectionText("West:");
        Indent(50); ControlsText("[D]");
        DirectionText("East: \n");

        //West
        if (ObjectNextToPlayer("West") != null)
        {
            Indent((Console.WindowWidth / 2) - 35); Console.Write(ObjectNextToPlayer("West").name);
            CooordinatesText(ObjectNextToPlayer("West").coordinates);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Indent((Console.WindowWidth / 2) - 35); Console.Write("Nothing of interest.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //East
        if (ObjectNextToPlayer("East") != null)
        {
            Indent(40); Console.Write(ObjectNextToPlayer("East").name);
            CooordinatesText(ObjectNextToPlayer("East").coordinates);
            Console.WriteLine();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Indent(40); Console.WriteLine("Nothing of interest.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //South
        Indent((Console.WindowWidth / 2) - 2); ControlsText("[S]");
        DirectionText("South: \n");
        if (ObjectNextToPlayer("South") != null)
        {
            Indent((Console.WindowWidth / 2) - 5); Console.Write(ObjectNextToPlayer("South").name);
            CooordinatesText(ObjectNextToPlayer("South").coordinates);
            Console.WriteLine();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Indent((Console.WindowWidth / 2) - 5); Console.WriteLine("Nothing of interest.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        Indent((Console.WindowWidth / 2) - 10); ControlsText("Press associated key to interact...");
    }


    public void LookAround()
    {
        Console.Clear();
        Player.Instance.DisplayPlayerInfo();
        Console.WriteLine("You look around and see:");
        var lookList = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].ObjectsInRange(Player.Instance.eyeSight);
        foreach (WorldObject obj in lookList)
        {
            Console.Write(obj.name); CooordinatesText(obj.coordinates); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("║"); Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        VisualDisplay.Instance.GridView(Player.Instance.eyeSight, Player.Instance.eyeSight, WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].defaultGround);
        GameManager.Instance.WaitForInput();
    }



    public WorldObject[] ObjectsInPlayerSight(int playerEyesight) //Get an array of World Objects near the player
    {
        List<WorldObject> objList = new List<WorldObject>();

        for (int z = -playerEyesight; z <= playerEyesight; z++) //Loop through z axis
            for (int x = -playerEyesight; x <= playerEyesight; x++) //within z axis loop, loop through all x axis
                if (WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates.ContainsKey(new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z)))
                    objList.Add(WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates[new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z)]);

        return objList.ToArray();
    }

    public WorldObject ObjectNextToPlayer(string Direction) //Input a direction and get the object next to the player, if there is one
    {
        WorldObject obj = null;

        switch (Direction)
        {
            case "North":
                if (WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates.ContainsKey(new Vector3(Player.Instance.coordinates.X, 0, Player.Instance.coordinates.Z + 1)))
                    obj = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates[new Vector3(Player.Instance.coordinates.X, 0, Player.Instance.coordinates.Z + 1)];
                break;
            case "South":
                if (WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates.ContainsKey(new Vector3(Player.Instance.coordinates.X, 0, Player.Instance.coordinates.Z - 1)))
                    obj = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates[new Vector3(Player.Instance.coordinates.X, 0, Player.Instance.coordinates.Z - 1)];
                break;
            case "East":
                if (WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates.ContainsKey(new Vector3(Player.Instance.coordinates.X + 1, 0, Player.Instance.coordinates.Z)))
                    obj = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates[new Vector3(Player.Instance.coordinates.X + 1, 0, Player.Instance.coordinates.Z)];
                break;
            case "West":
                if (WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates.ContainsKey(new Vector3(Player.Instance.coordinates.X - 1, 0, Player.Instance.coordinates.Z)))
                    obj = WorldAreaManager.Instance.worldAreas[Player.Instance.currentArea].objectBycoordinates[new Vector3(Player.Instance.coordinates.X - 1, 0, Player.Instance.coordinates.Z)];
                break;
        }

        return obj;
    }


}


