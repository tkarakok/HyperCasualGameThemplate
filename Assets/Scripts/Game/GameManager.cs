using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] GameObject _confetti;
    
    #region Confetti
    public void Confetti()
    {
        _confetti.SetActive(true);
    }
    #endregion

    #region End Game Actions
    public void LevelComplated()
    {
        EventManager.Instance.EndGame();
    }
    public void LevelFailed()
    {
        EventManager.Instance.GameOver();
    }
    #endregion

}
