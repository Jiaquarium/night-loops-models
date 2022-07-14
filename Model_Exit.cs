using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
/// <summary>
/// Defines metadata of player's state after exit
/// </summary>
public class Model_Exit
{
    public int level;
    public Vector3 playerSpawn;
    public Directions facingDirection;    

    public Model_Exit (
        int _level,
        Vector3 _playerSpawn,
        Directions _facingDirection
    )
    {
        level           = _level;
        playerSpawn     = _playerSpawn;
        facingDirection = _facingDirection;
    }
}
