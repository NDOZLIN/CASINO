using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : Hand 
{
    public override void RefreshHandUI() 
    {
        base.RefreshHandUI();
        foreach(Transform t in transform) 
        {
            t.GetComponent<Card>().IsPlayerHandCard = true;
        }
    }
}
