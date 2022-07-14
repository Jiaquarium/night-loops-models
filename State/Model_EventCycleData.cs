[System.Serializable]
public class Model_EventCycleData
{
    public bool didInteractPositivelyWithIds;
    public int idsPositiveInteractionCount;
    public int didTalkToElleniaCountdown;

    public Model_EventCycleData(
        bool _didInteractPositivelyWithIds,
        int _idsPositiveInteractionCount,
        int _didTalkToElleniaCountdown
    )
    {
        didInteractPositivelyWithIds = _didInteractPositivelyWithIds;
        idsPositiveInteractionCount = _idsPositiveInteractionCount;
        didTalkToElleniaCountdown = _didTalkToElleniaCountdown;
    }
}
