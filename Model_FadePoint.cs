using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Model_FadePoint
{
    public enum States
    {
        Show,
        Hide
    }
    public FadeSpeeds fadeSpeed;
    public States state;
    public Transform target;
}
