using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Model_DialogueNode
{
    public Model_Dialogue dialogue;
    
    public bool showDialogueOnAction;
    
    // Originally used in conjunction with previous node's showDialogueOnAction = true to leave up dialogue
    // to show multiple dialogue boxes at once.
    [Tooltip("Set to true to leave nonempty canvases filled on current dialogue (e.g. 2+ concurrent dialogues)")]
    public bool isKeepLastDialogueUp;
    
    [Tooltip("Set to true to leave up dialogue Box (use when calling another Node and don't want fade).")]
    public bool isKeepThisDialogueUp;
    
    public bool isDynamicLines;
    
    [Tooltip("Force choices. You can also set >1 children Nodes to activate choices.")]
    public bool isChoices;
    
    public Script_DialogueNode[] children;
    public string choiceText;
    public string action;
    public string updateAction; // key to be called on update
    public string locationType; // where canvas should be
    public string type; // e.g. read,
    public InputMode inputMode;
    public Script_FullArt fullArt;
    public FadeSpeeds fadeIn;
    public FadeSpeeds fadeTransition = FadeSpeeds.None;
    public FadeSpeeds fadeOut;
    
    // Option to leave up the current Full Art. Next Full Art node must be set as fadeIn: FadeSpeeds.None.
    public bool isLeaveFullArtUp;
    
    public bool fullArtWithBg = true;
    public bool disableReturnToDefaultFaceDir;
    public DialogueTypingSpeed typingSpeed;
    public UnityEvent OnNextNodeAction;
    public UnityEvent OnBeforeNodeAction;
    public Model_NodeChoiceEvent OnAutoChoice;

    public bool isZalgofy;
    public bool isCustomDialogueFadeIn;
    public FadeSpeeds dialogueFadeInSpeed = FadeSpeeds.None;
    public bool isCustomDialogueFadeOut;
    public FadeSpeeds dialogueFadeOutSpeed = FadeSpeeds.None;
}

public enum DialogueTypingSpeed
{
    Default = 0,
    Fast = 1    
}

public class OnNextNodeChoiceArgs
{
    public int choice = -1;
}
