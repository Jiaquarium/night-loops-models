[System.Serializable]
public class Model_LevelBehavior_20
{
    public bool isKingIntroCutSceneDone;
    public bool isMyneR2CutsceneDone;
    public bool isMyneTrueEndingCutsceneDone;
    public Seasons season;
    public bool entranceCutSceneDone;
    public bool isPuzzleComplete;
    public bool didPickUpMasterKey;
    public bool didUnlockMasterLock;

    public Model_LevelBehavior_20(
        bool _isKingIntroCutSceneDone,
        bool _isMyneR2CutsceneDone,
        bool _isMyneTrueEndingCutsceneDone,
        Seasons _season,
        bool _entranceCutSceneDone,
        bool _isPuzzleComplete,
        bool _didPickUpMasterKey,
        bool _didUnlockMasterLock
    )
    {
        isKingIntroCutSceneDone = _isKingIntroCutSceneDone;
        isMyneR2CutsceneDone    = _isMyneR2CutsceneDone;
        isMyneTrueEndingCutsceneDone = _isMyneTrueEndingCutsceneDone;
        season                  = _season;
        entranceCutSceneDone    = _entranceCutSceneDone;
        isPuzzleComplete        = _isPuzzleComplete;
        didPickUpMasterKey      = _didPickUpMasterKey;
        didUnlockMasterLock     = _didUnlockMasterLock;
    }
}
