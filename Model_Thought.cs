﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Model_Thought
{
    public DateTime dateTimeCreated;
    
    [TextArea(3, 10)]
    public string thought;

    public Model_Thought(
        DateTime _dateTimeCreated,
        string _thought
    )
    {
        dateTimeCreated = _dateTimeCreated;
        thought = _thought;
    }
}
