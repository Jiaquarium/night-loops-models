/// <summary>
/// Use to hold references to Monobehaviors. For saving state use PianoStateData.
/// </summary>

[System.Serializable]
public class Model_PianoData
{
    public Script_LevelBehavior levelBehavior;
    public Script_ExitMetadataObject spawn;
    public bool isRemembered;
}
