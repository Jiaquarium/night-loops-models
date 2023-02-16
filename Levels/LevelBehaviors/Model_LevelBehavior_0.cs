[System.Serializable]
public class Model_LevelBehavior_0
{
    public bool didStartThought;
    public bool didStartThoughtSea;
    public bool[] demonSpawns;
    public bool isDone;

    public Model_LevelBehavior_0(
        bool _didStartThought,
        bool _didStartThoughtSea,
        bool[] _demonSpawns,
        bool _isDone
    )
    {
        didStartThought                 = _didStartThought;
        didStartThoughtSea              = _didStartThoughtSea;
        demonSpawns                     = _demonSpawns;
        isDone                          = _isDone;
    }
}
