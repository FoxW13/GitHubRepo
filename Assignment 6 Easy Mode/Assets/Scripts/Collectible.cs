using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour, ICollectible
{
    protected int value;

    public virtual void Collect()
    {
        Debug.Log("Collected item!");
        Destroy(gameObject); 
    }

    public int GetValue()
    {
        return value; 
    }
}
