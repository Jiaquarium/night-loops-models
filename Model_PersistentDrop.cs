[System.Serializable]
public class Model_PersistentDrop
{
    public float[] location;
    public string itemId;
    public int levelBehavior;

    public Model_PersistentDrop(
        float[] _location,
        string _itemId,
        int _levelBehavior
    )
    {
        location = _location;
        itemId = _itemId;
        levelBehavior = _levelBehavior;
    }
}
