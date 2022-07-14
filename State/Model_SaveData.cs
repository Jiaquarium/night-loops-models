using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_SaveData
{
    public Model_GameData gameData { get; set; }
    public Model_PlayerState playerData { get; set; }
    
    public Model_Entry[] entriesData { get; set; }
    
    public string[] stickersIds { get; set; }
    public string[] itemsIds { get; set; }
    public string[] equipmentIds { get; set; }
    
    public Model_PersistentDrop[] drops { get; set; }
    
    public Model_Names namesData { get; set; }
    
    public Model_ScarletCipher scarletCipherData { get; set; }
    public Model_RunData runData { get; set; } = new Model_RunData(); // need this default value to access data.runData
    public Model_EventCycleData eventCycleData { get; set; }

    public Model_MynesMirror mynesMirrorData { get; set; }

    public Model_PianoStateData[] pianosStateData { get; set; }
}