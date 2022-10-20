[System.Serializable]
/// <summary>
/// Note: JSON Utility cannot serialize Properties
/// so do not use the same format as Model_SaveData
/// </summary>
public class Model_SettingsData
{
    public Model_KeyBindsData keyBindsData;
    public Model_SystemData systemData;
}