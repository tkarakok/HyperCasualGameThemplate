using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static volatile T _instance = null;

    [SerializeField] protected  bool _isDontDestroyOnLoad;

    private void Awake()
    {
        if (_isDontDestroyOnLoad)
        {
            DontDestroyOnLoad(this);
        }
    }

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;
            }
            return _instance;
        }
    }
}
