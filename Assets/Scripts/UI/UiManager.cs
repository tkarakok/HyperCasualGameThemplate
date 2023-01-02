using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiManager : Singleton<UiManager>
{
    #region Panels
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject inGamePanel;
    public GameObject gameOverPanel;
    public GameObject endGamePanel;
    #endregion
    #region Private Fields
    private GameObject _currentPanel;
    #endregion

    private void Awake()
    {
        if (_currentPanel == null)
        {
            _currentPanel = mainMenuPanel;
        }
    }

    public void StartButton()
    {
        PanelChange(inGamePanel);
        /*
        if (HomaInitialize.Instance.Initialize)
        {
            DefaultAnalytics.GameplayStarted();
        }
        */
        StateManager.Instance.State = State.InGame;
        EventManager.Instance.InGame();
    }

    #region Panel Change Function
    /// <summary>
    /// We can close current panel after then we'll open new panel
    /// </summary>
    /// <param name="openPanel"> Panel To Open </param>
    void PanelChange(GameObject openPanel)
    {
        _currentPanel.SetActive(false);
        _currentPanel = openPanel;
        openPanel.SetActive(true);
    }
    #endregion

    #region Level Actionss
    public void RestartLevel()
    {
        LevelManager.Instance.ChangeLevel("Level " + LevelManager.Instance.GetLevelName());
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SaveManager.Instance.SaveState.LevelCounter++;
        SaveManager.Instance.Save();
        LevelManager.Instance.ChangeLevel("Level " + LevelManager.Instance.GetLevelName());
        
    }
    #endregion

    #region End Game Action
    public void GameOver()
    {
        PanelChange(gameOverPanel);

    }

    public void EndGame()
    {
        PanelChange(endGamePanel);
    }
    #endregion


}
