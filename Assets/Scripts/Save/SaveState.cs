using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveState
{
    public int LevelCounter;
    public void SetInitialValues()
    {
        LevelCounter = 1;
    }
}
