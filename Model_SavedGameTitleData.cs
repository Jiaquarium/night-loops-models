/// <summary>
/// For title screen view
/// </summary>
[System.Serializable]
public class Model_SavedGameTitleData
{
    public string run;
    public float clockTime;
    public string name;
    public string headline;
    public long date;
    public float playTime;
    public int maskCount;
    public int[] scarletCipher;

    public Model_SavedGameTitleData(
        string _run,
        float _clockTime,
        string _name,
        string _headline,
        int _maskCount,
        int[] _scarletCipher,
        long _date,
        float _playTime
    )
    {
        run         = _run;
        clockTime   = _clockTime;
        name        = _name;
        headline    = _headline;
        maskCount   = _maskCount;
        scarletCipher = _scarletCipher;
        date        = _date;
        playTime    = _playTime;
    }
}
