using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_GameData
{
    public int runIdx { get; set; }
    public int level { get; set; }
    public int cycleCount { get; set; }
    public float totalPlayTime { get; set; }
    public Script_TransitionManager.Endings activeEnding { get; set; }
    public int faceOffCounter { get; set; }

    public Model_GameData(
        int _runIdx,
        int _level,
        int _cycleCount,
        float _totalPlayTime,
        Script_TransitionManager.Endings _activeEnding,
        int _faceOffCounter
    )
    {
        runIdx              = _runIdx;
        level               = _level;
        cycleCount          = _cycleCount;
        totalPlayTime       = _totalPlayTime;
        activeEnding        = _activeEnding;
        faceOffCounter      = _faceOffCounter;
    }
}