using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pool
{
    public GameObject PoolObjectPrefab;
    public Transform PoolParent;
    public int PoolSize;
    public Queue<GameObject> PoolQueue;

    private Vector3 _firstScale;
    private Quaternion _firstRotation;
    
    public void Initialize()
    {
        PoolQueue = new Queue<GameObject>();
        for (int i = 0; i < PoolSize; i++)
        {
            GameObject newPoolObject = GameObject.Instantiate(PoolObjectPrefab, PoolParent);
            _firstScale = newPoolObject.transform.localScale;
            _firstRotation = newPoolObject.transform.rotation;
            newPoolObject.SetActive(false);
            PoolQueue.Enqueue(newPoolObject);
        }
    }

    public GameObject GetPoolObject()
    {
        GameObject poolObject = PoolQueue.Dequeue();
        Reset(poolObject);
        poolObject.SetActive(true);
        PoolQueue.Enqueue(poolObject);
        return poolObject;
    }

    private void Reset(GameObject obj)
    {
        obj.transform.rotation = _firstRotation;
        obj.transform.localScale = _firstScale;
    }
}