[System.Serializable]
public class Model_ScarletCipher
{
    public int[] scarletCipher;
    public bool[] visibility;
    public bool[] mirrorsActivation;
    public bool[] mirrorsSolved;

    public Model_ScarletCipher(
        int[] _scarletCipher,
        bool[] _visibility,
        bool[] _mirrorsActivation,
        bool[] _mirrorsSolved
    )
    {
        scarletCipher       = _scarletCipher;
        visibility          = _visibility;
        mirrorsActivation   = _mirrorsActivation;
        mirrorsSolved       = _mirrorsSolved;
    }
}
