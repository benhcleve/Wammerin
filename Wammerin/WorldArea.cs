using System;
using System.Collections.Generic;
using System.Numerics;

public class WorldArea
{
    public string name;
    public List<WorldObject> worldObjects = new List<WorldObject>();
    public List<Ground> worldGrounds = new List<Ground>();

    public Dictionary<Vector3, WorldObject> objectBycoordinates = new Dictionary<Vector3, WorldObject>();
    public Dictionary<Vector3, Ground> groundBycoordinates = new Dictionary<Vector3, Ground>();

    public Ground defaultGround;

    public void UpdateOBL()
    {
        objectBycoordinates.Clear();
        foreach (WorldObject obj in worldObjects)
            objectBycoordinates.Add(obj.coordinates, obj);

        groundBycoordinates.Clear();
        foreach (Ground g in worldGrounds)
            groundBycoordinates.Add(g.coordinates, g);


    }

    public WorldObject[] ObjectsInRange(int range) //Get an array of World Objects near the player
    {
        List<WorldObject> objList = new List<WorldObject>();

        for (int z = -range; z <= range; z++) //Loop through z axis
            for (int x = -range; x <= range; x++) //within z axis loop, loop through all x axis
                if (objectBycoordinates.ContainsKey(new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z)))
                    objList.Add(objectBycoordinates[new Vector3(x + Player.Instance.coordinates.X, 0, z + Player.Instance.coordinates.Z)]);

        return objList.ToArray();
    }

}
