[System.Serializable]
public class Model_AutoSaves
{
    public int spikeRoomTryCounterAutoUpdate;
    public bool gameDidGoodEnding;
    
    public Model_AutoSaves(
        int _spikeRoomTryCounterAutoUpdate,
        bool _gameDidGoodEnding
    )
    {
        spikeRoomTryCounterAutoUpdate = _spikeRoomTryCounterAutoUpdate;
        gameDidGoodEnding = _gameDidGoodEnding;
    }
}