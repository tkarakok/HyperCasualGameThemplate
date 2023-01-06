using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : Singleton<SaveManager>
{
    #region Fields
    public SaveState SaveState = new SaveState();

    private const string _firstSaveCompletedString = "FirstSaveCompleted";
    private const string _shopObjectDictionaryString = "ShopObjectDictionary";
    #endregion

    private void Start()
    {
        if (!_isDontDestroyOnLoad)
            _isDontDestroyOnLoad = true;
        Load();
        LevelManager.Instance.ChangeLevel(SaveState.LevelCounter);
    }
    public void Save()
    {
        ES3.Save(_firstSaveCompletedString, true); // Save the "first Save"
        ES3.Save("state", SaveState); // Save the "State"

        Debug.Log("The game session saved successfully");
    }
    public void Load()
    {
        bool isExist = ES3.KeyExists(_firstSaveCompletedString);
        if (!isExist)
        {
            SaveState = new SaveState();
            SaveState.SetInitialValues();
            Save();

            Debug.Log("The inital data created successfully");
        }
        else if (isExist)
        {
            SaveState = ES3.Load("state", new SaveState());

            Debug.Log("The saved data loaded successfully");
        }
    }
}