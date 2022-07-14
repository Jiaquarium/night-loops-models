[System.Serializable]
public class Model_RunData
{
    public Model_LevelsData levelsData { get; set; } = new Model_LevelsData(); // need this default value to access runData.levelsData initially
}
