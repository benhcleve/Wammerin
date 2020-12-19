using System;
using System.Collections.Generic;
using System.Numerics;

public class WorldAreaManager
{
    private static WorldAreaManager instance = new WorldAreaManager();
    public static WorldAreaManager Instance { get { return instance; } }

    public Dictionary<String, WorldArea> worldAreas = new Dictionary<String, WorldArea>();



    public void GenerateTestArea()
    {
        WorldArea newArea = new WorldArea();
        newArea.name = "Test Area";
        newArea.defaultGround = new Grass();

        //Test Building Walls
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(3, 0, -3) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(3, 0, -2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(3, 0, -1) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(3, 0, -0) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(3, 0, 1) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(3, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-3, 0, -3) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-3, 0, -2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-3, 0, -1) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-3, 0, -0) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-3, 0, 1) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-3, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-2, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-1, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(0, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(1, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(2, 0, 2) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-2, 0, -3) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(-1, 0, -3) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(1, 0, -3) });
        newArea.worldObjects.Add(new StoneWall { coordinates = new Vector3(2, 0, -3) });
        //Test Building Floor
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(2, 0, -2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(1, 0, -2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(0, 0, -2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-1, 0, -2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-2, 0, -2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(2, 0, -1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(1, 0, -1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(0, 0, -1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-1, 0, -1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-2, 0, -1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(2, 0, 0) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(1, 0, 0) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(0, 0, 0) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-1, 0, 0) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-2, 0, 0) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(2, 0, 1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(1, 0, 1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(0, 0, 1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-1, 0, 1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-2, 0, 1) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(2, 0, 2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(1, 0, 2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(0, 0, 2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-1, 0, 2) });
        newArea.worldGrounds.Add(new StoneFloor { coordinates = new Vector3(-2, 0, 2) });

        //Dirt path
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(-5, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(-4, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(-3, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(-2, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(-1, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(0, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(1, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(2, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(3, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(4, 0, -5) });
        newArea.worldGrounds.Add(new Dirt { coordinates = new Vector3(5, 0, -5) });


        //Oak Trees
        newArea.worldObjects.Add(new OakTree { coordinates = new Vector3(7, 0, -1) });
        newArea.worldObjects.Add(new OakTree { coordinates = new Vector3(5, 0, -1) });
        newArea.worldObjects.Add(new OakTree { coordinates = new Vector3(0, 0, 6) });
        newArea.worldObjects.Add(new OakTree { coordinates = new Vector3(-5, 0, -1) });






        WorldAreaManager.Instance.worldAreas.Add(newArea.name, newArea);
    }
}