using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public virtual void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }

    public virtual void OnTriggerStay(Collider other)
    {
        throw new NotImplementedException();
    }
    
    public virtual void OnTriggerExit(Collider other)
    {
        throw new NotImplementedException();
    }
}
