using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_Player
{
    public Vector3 playerSpawnLocation;
    public Directions direction = Directions.Up;
    public bool isLightOn;
    public bool isReflectionOn;
    public Vector3 reflectionVector;
    public bool isForceSortingLayer;
    public bool isForceSortingLayerAxisZ;
}
