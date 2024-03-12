[System.Serializable]
/// <summary>
/// Note: JSON Utility cannot serialize Properties
/// so do not use the same format as Model_SaveData
/// </summary>
public class Model_SettingsData
{
    public string rewiredKeyboardMapDefault;
    public string rewiredJoystickMapDefault;
    
    // The type of joystick the joystick map belongs to.
    public Script_PlayerInputManager.JoystickKnownState savedJoystickMapKnownState;
    
    public Model_SystemData systemData;
}