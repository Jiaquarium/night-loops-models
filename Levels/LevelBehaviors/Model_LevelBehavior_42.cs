[System.Serializable]
public class Model_LevelBehavior_42
{
    public bool didPickUpLastWellMap;
    public bool didPickUpSpeedSeal;
    public bool isMooseQuestDone;
    public bool didPlayFaceOff;

    public Model_LevelBehavior_42(
        bool _didPickUpLastWellMap,
        bool _didPickUpSpeedSeal,
        bool _isMooseQuestDone,
        bool _didPlayFaceOff
    )
    {
        didPickUpLastWellMap    = _didPickUpLastWellMap;
        didPickUpSpeedSeal      = _didPickUpSpeedSeal;
        isMooseQuestDone        = _isMooseQuestDone; 
        didPlayFaceOff          = _didPlayFaceOff;
    }
}
