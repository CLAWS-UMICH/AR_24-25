using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Waypoint
{   
    public int Id { get; set; }
    public string Name { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Z {get; set; }
    public string Letter {get; set;}
    public string Type{get; set;}
    public GameObject WaypointObject { get; set; }

    public Waypoint(int id, string name, float x, float y, float z, string letter, string type, GameObject waypointObject)
    {
        Id = id;
        Name = name;
        X = x;
        Y = y;
        Z = z;
        Letter = letter;
        Type = type;
        WaypointObject = waypointObject;
    }
    

   
}

