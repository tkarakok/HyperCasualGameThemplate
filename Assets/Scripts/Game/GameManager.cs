using System;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using  System;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] GameObject _confetti;

    private void Start()
    {
#if !UNITY_EDITOR
        Application.targetFrameRate = 60;
#endif
        EventManager.Instance.EndGame += LevelCompleted;
        EventManager.Instance.GameOver += LevelFailed;
    }

    #region Confetti
    public void Confetti()
    {
        _confetti.SetActive(true);
    }
    #endregion

    #region End Game Actions
    public void LevelCompleted()
    {
        StateManager.Instance.ChangeState(State.EndGame);
    }
    public void LevelFailed()
    {
        StateManager.Instance.ChangeState(State.GameOver);
    }
    #endregion

}
