using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_MoveSet
{
    public Directions[] moves;
    public Directions endFaceDirection;
    public NPCEndCommands NPCEndCommand;

    public Model_MoveSet(
        Directions[] _moves,
        Directions _endFaceDirection,
        NPCEndCommands _NPCEndCommand
    )
    {
        moves = _moves;
        endFaceDirection = _endFaceDirection;
        NPCEndCommand = _NPCEndCommand;
    }
}
