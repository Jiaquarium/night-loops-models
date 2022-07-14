/// <summary>
/// Use only to save State data for saving and loading.
/// </summary>

[System.Serializable]
public class Model_PianoStateData
{
    public bool isRemembered;

    public Model_PianoStateData(
        bool _isRemembered
    )
    {
        isRemembered = _isRemembered;
    }
}
