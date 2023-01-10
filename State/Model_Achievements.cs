[System.Serializable]
public class Model_Achievements
{
    public bool achPsyConn;
    public bool achWord;
    public bool achDancePerfect;
    public bool achSpikePerfect;
    public bool achBreakIce;
    public bool achWell;
    public bool achSin;
    public bool achRaveStage;
    public bool achCctvCode;
    public bool achNauticalDawn;
    public bool achSealing;
    public bool achSadist;

    // For Sadist Achievement
    public bool didElderSealing;
    public bool didIdsR2;
    public bool didElleniaR2;
    public bool didEileenR2;

    public void InitialState()
    {
        achPsyConn = false;
        achWord = false;
        achDancePerfect = false;
        achSpikePerfect = false;
        achBreakIce = false;
        achSadist = false;
        achWell = false;
        achSin = false;
        achRaveStage = false;
        achCctvCode = false;
        achNauticalDawn = false;
        achSealing = false;
        
        didElderSealing = false;
        didIdsR2 = false;
        didElleniaR2 = false;
        didEileenR2 = false;
    }

    public Model_Achievements(
        bool _achPsyConn = false,
        bool _achWord = false,
        bool _achDancePerfect = false,
        bool _achSpikePerfect = false,
        bool _achBreakIce = false,
        bool _achSadist = false,
        bool _achWell = false,
        bool _achSin = false,
        bool _achRaveStage = false,
        bool _achCctvCode = false,
        bool _achNauticalDawn = false,
        bool _achSealing = false,
        bool _didElderSealing = false,
        bool _didIdsR2 = false,
        bool _didElleniaR2 = false,
        bool _didEileenR2 = false
    )
    {
        achPsyConn = _achPsyConn;
        achWord = _achWord;
        achDancePerfect = _achDancePerfect;
        achSpikePerfect = _achSpikePerfect;
        achBreakIce = _achBreakIce;
        achSadist = _achSadist;
        achWell = _achWell;
        achSin = _achSin;
        achRaveStage = _achRaveStage;
        achCctvCode = _achCctvCode;
        achNauticalDawn = _achNauticalDawn;
        achSealing = _achSealing;

        didElderSealing = _didElderSealing;
        didIdsR2 = _didIdsR2;
        didElleniaR2 = _didElleniaR2;
        didEileenR2 = _didEileenR2;
    }
}