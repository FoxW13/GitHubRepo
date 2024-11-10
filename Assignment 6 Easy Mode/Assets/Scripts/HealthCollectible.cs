using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : Collectible
{
    private void Awake()
    {
        value = 10;
    }

    public override void Collect()
    {
        base.Collect();
        
        Player.Instance.IncreaseHealth(value);
    }
}
