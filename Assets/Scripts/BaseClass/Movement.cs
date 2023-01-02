using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private SplineFollower _splineFollower;

    public SplineFollower SplineFollower { get => _splineFollower; set => _splineFollower = value; }
}
