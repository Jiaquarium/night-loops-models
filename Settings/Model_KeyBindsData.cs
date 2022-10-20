[System.Serializable]
public class Model_KeyBindsData
{
    public string Interact;
    public string Inventory;
    public string MaskEffect;
    public string Speed;

    public Model_KeyBindsData(
        string _Interact,
        string _Inventory,
        string _MaskEffect,
        string _Speed
    )
    {
        Interact = _Interact;
        Inventory = _Inventory;
        MaskEffect = _MaskEffect;
        Speed = _Speed;
    }
}
