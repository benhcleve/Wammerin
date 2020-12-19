using System;
using System.Numerics;

public class WorldObject
{
    public virtual string name { get; protected set; }
    public virtual string shortDescription { get; protected set; }
    public virtual string longDescription { get; protected set; }
    public virtual void visual() { }

    public Vector3 coordinates;

}
