using System;
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
    [SerializeField] private TMP_Text _levelText;
    #endregion

    private void Awake()
    {
        if (_currentPanel == null)
        {
            _currentPanel = mainMenuPanel;
        }
    }

    private void Start()
    {
        EventManager.Instance.InGame += SetLevelText;
    }

    public void StartButton()
    {
        PanelChange(inGamePanel);
        StateManager.Instance.State = State.InGame;
        EventManager.Instance.InGame();
    }

    private void SetLevelText()
    {
        if (SaveManager.Instance != null)
            _levelText.text = "LEVEL " + SaveManager.Instance.SaveState.LevelCounter;
        else
            _levelText.gameObject.SetActive(false);
    }
    
    #region Panel Change Function
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
        LevelManager.Instance.ChangeLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SaveManager.Instance.SaveState.LevelCounter++;
        SaveManager.Instance.Save();
        LevelManager.Instance.ChangeLevel(SaveManager.Instance.SaveState.LevelCounter);
        
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
