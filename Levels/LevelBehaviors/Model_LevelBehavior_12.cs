/// <summary>
/// Model Level Behaviors are the data representation of the LB for save loading
/// Properties here should match STATE DATA defined in respective LBs, gawd so much work
/// </summary>
[System.Serializable]
public class Model_LevelBehavior_12
{
    public bool isDone;
    public bool isCutSceneDone;

    public Model_LevelBehavior_12(
        bool _isDone,
        bool _isCutSceneDone
    )
    {
        isDone = _isDone;
        isCutSceneDone = _isCutSceneDone;
    }
}
