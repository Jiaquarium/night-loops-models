[System.Serializable]
public class Model_LevelBehavior_0
{
    public bool didStartThought;
    public bool[] demonSpawns;
    public bool isDone;

    public Model_LevelBehavior_0(
        bool _didStartThought,
        bool[] _demonSpawns,
        bool _isDone
    )
    {
        didStartThought                 = _didStartThought;
        demonSpawns                     = _demonSpawns;
        isDone                          = _isDone;
    }
}
