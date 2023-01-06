using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : Singleton<LevelManager>
{
    private Scene _lastLoadedScene;
    private int _currentLevel;
    private int _maxLevel;

    public int CurrentLevel { get => _currentLevel; set => _currentLevel = value; }
    public int MaxLevel { get => _maxLevel; set => _maxLevel = value; }

    private void Start()
    {
        if (!_isDontDestroyOnLoad)
            _isDontDestroyOnLoad = true;
        MaxLevel = SceneManager.sceneCountInBuildSettings - 1;
    }

    public int GetLevelName()
    {
        CurrentLevel = SaveManager.Instance.SaveState.LevelCounter;
        
        return CurrentLevel;
    }

    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

}