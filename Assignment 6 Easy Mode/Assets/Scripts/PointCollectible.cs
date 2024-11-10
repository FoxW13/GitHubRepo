using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollectible : Collectible
{
    private void Awake()
    {
        value = 5; // Set points value
    }

    public override void Collect()
    {
        base.Collect();
        // Additional behavior: increase player score
        Player.Instance.AddScore(value);
    }
}
