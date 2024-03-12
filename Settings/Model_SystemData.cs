[System.Serializable]
public class Model_SystemData
{
    // All volume data saved as dB
    public float masterVolume;
    public float musicVolume;
    public float fxVolume;
    public bool isScreenshakeDisabled;

    public Model_SystemData(
        float _masterVolume,
        float _musicVolume,
        float _fxVolume,
        bool _isScreenshakeDisabled
    )
    {
        masterVolume = _masterVolume;
        musicVolume = _musicVolume;
        fxVolume = _fxVolume;
        isScreenshakeDisabled = _isScreenshakeDisabled;
    }
}
