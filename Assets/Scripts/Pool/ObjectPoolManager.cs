using System;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public Pool Pool;
    private void Start()
    {
        Pool.Initialize();
    }
}