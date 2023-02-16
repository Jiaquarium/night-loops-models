[System.Serializable]
public class Model_LevelBehavior_42
{
    public bool didPickUpLastWellMap;
    public bool didPickUpSpeedSeal;
    public bool isMooseQuestDone;
    public bool didPlayFaceOff;
    public bool didSpecialIntro;
    public bool didWellTalkInitialDialogue;

    public Model_LevelBehavior_42(
        bool _didPickUpLastWellMap,
        bool _didPickUpSpeedSeal,
        bool _isMooseQuestDone,
        bool _didPlayFaceOff,
        bool _didSpecialIntro,
        bool _didWellTalkInitialDialogue
    )
    {
        didPickUpLastWellMap    = _didPickUpLastWellMap;
        didPickUpSpeedSeal      = _didPickUpSpeedSeal;
        isMooseQuestDone        = _isMooseQuestDone; 
        didPlayFaceOff          = _didPlayFaceOff;
        didSpecialIntro         = _didSpecialIntro;
        didWellTalkInitialDialogue = _didWellTalkInitialDialogue;
    }
}
