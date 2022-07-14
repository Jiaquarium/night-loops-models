[System.Serializable]
public class Model_MynesMirror
{
    public int interactionCount;
    public bool didSealingDialogue;

    public Model_MynesMirror(
        int _interactionCount,
        bool _didSealingDialogue
    )
    {
        interactionCount        = _interactionCount;
        didSealingDialogue      = _didSealingDialogue;
    }
}
