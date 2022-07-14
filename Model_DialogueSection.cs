using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_DialogueSection
{
    [TextArea(3, 10)]
    public string[] lines;
    
    [Space(60)]
    
    public bool isUnskippable;
    public bool noContinuationIcon;
    public bool waitForTimeline;
}
