using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampManager : Singleton<ClampManager>
{
    public float ClampValue(float clampValue, float minValue, float maxValue)
    {
        return clampValue = Mathf.Clamp(clampValue,minValue,maxValue);
    }
}
