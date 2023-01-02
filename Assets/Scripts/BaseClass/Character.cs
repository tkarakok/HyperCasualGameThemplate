using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float _horizontalSpeed;
    private float _followSpeed;
    private float _minLimitX;
    private float _maxLimitX;

    public float HorizontalSpeed { get => _horizontalSpeed; set => _horizontalSpeed = value; }
    public float FollowSpeed { get => _followSpeed; set => _followSpeed = value; }
    public float MinLimitX { get => _minLimitX; set => _minLimitX = value; }
    public float MaxLimitX { get => _maxLimitX; set => _maxLimitX = value; }
}
