[System.Serializable]
public class Model_LevelBehavior_24
{
    public bool isPuzzleComplete;
    public bool didPickUpSpringStone;
    public bool didPlayFaceOff;

    public Model_LevelBehavior_24(
        bool _isPuzzleComplete,
        bool _didPickUpSpringStone,
        bool _didPlayFaceOff
    )
    {
        isPuzzleComplete        = _isPuzzleComplete;
        didPickUpSpringStone    = _didPickUpSpringStone;
        didPlayFaceOff          = _didPlayFaceOff;
    }
}
