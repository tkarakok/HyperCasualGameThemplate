using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasClamp : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles);
    }
}
