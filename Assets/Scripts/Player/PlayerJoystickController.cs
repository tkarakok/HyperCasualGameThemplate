using UnityEngine;

public class PlayerJoystickController : MonoBehaviour
{
    public FloatingJoystick FloatingJoystick;
    public float horizontal { get; private set; }
    public float vertical { get; private set; }
    public float heading { get; private set; }

    float headingT;
    float _camOffset = 30f;

    public void SetInput(FloatingJoystick dynamicJoystick)
    {
        horizontal = dynamicJoystick.Horizontal;
        vertical = dynamicJoystick.Vertical;


        heading = Mathf.Atan2(horizontal, vertical);

    }
    
    public void Rotate()
    {
        if (Mathf.Abs(horizontal) > 0.001f && Mathf.Abs(vertical) > 0.001f)
        {
            headingT = heading;
            transform.rotation = Quaternion.Euler(0f, heading * Mathf.Rad2Deg, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, headingT * Mathf.Rad2Deg, 0);
        }
    }
}