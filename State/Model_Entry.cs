using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_Entry
{
    public string nameId;
    public string text;
    public string headline;
    public long timestamp;

    public Model_Entry(
        string _nameId,
        string _text,
        string _headline,
        long _timestamp
    )
    {
        nameId      = _nameId;
        text        = _text;
        headline    = _headline;
        timestamp   = _timestamp;
    }
}
