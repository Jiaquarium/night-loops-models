using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_PlayerState
{
    public int spawnX;
    public int spawnY;
    public int spawnZ;
    public Directions faceDirection;
    public Model_PlayerStats stats;

    public Model_PlayerState(
        int _spawnX,
        int _spawnY,
        int _spawnZ,
        Directions _faceDirection
    )
    {
        spawnX = _spawnX;
        spawnY = _spawnY;
        spawnZ = _spawnZ;
        faceDirection = _faceDirection;
    }
}