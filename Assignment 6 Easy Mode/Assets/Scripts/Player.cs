using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();
        }
    }

    public void IncreaseHealth(int amount)
    {
        Debug.Log("Increased Health by " + amount);
    }

    public void AddScore(int points)
    {
        Debug.Log("Added Score: " + points);
    }
}
