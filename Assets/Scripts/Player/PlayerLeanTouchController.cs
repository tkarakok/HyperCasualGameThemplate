using System;
using Lean.Touch;
using UnityEngine;

[RequireComponent(typeof(PlayerAnimationController))]
[RequireComponent(typeof(PlayerCollisionController))]
[RequireComponent(typeof(Player))]
public class PlayerLeanTouchController : MovementController
{
    private void OnEnable()
    {
        LeanTouch.OnFingerDown += OnFingerDown;
        LeanTouch.OnFingerUp += OnFingerUp;
        LeanTouch.OnFingerTap += OnFingerTap;
        LeanTouch.OnFingerUpdate += OnFingerUpdate;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerDown -= OnFingerDown;
        LeanTouch.OnFingerUp -= OnFingerUp;
        LeanTouch.OnFingerTap -= OnFingerTap;
        LeanTouch.OnFingerUpdate -= OnFingerUpdate;
    }


    #region Lean Touch Funcs
    private void OnFingerDown(LeanFinger finger){}
    private void OnFingerUp(LeanFinger finger){}
    private void OnFingerTap(LeanFinger finger){}
    private void OnFingerUpdate(LeanFinger finger){}
    #endregion
}