using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    Animator _animator;

    bool _walk;
    bool _idle;

    public bool Walk
    {
        get => _walk;
        set => _walk = value;
    }

    public virtual void Start()
    {
        SetAnimator();
    }

    #region Set Animator
    private void SetAnimator()
    {
        _animator = GetComponentInChildren<Animator>(); 
    }
    #endregion

    #region Movement Animations
    public float GetWalk()
    {
        return _animator.GetFloat("Movement");
    }
    public void SetWalkForBug()
    {
        _animator.SetFloat("Movement", 1, 0, Time.deltaTime);
        _walk = true;
        _idle = false;
    }
    public void SetWalk()
    {
        if (_walk) return;
            _animator.SetFloat("Movement", 1 ,0,Time.deltaTime);
        _walk = true;
        _idle = false;
    }

    public void SetIdle()
    {
        if (_idle) return;
        _animator.SetFloat("Movement", 0, 0, Time.deltaTime);
        _walk = false;
        _idle = true;
    }

    #endregion

}
