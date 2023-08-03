using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHand : Hand 
{
    public override void RefreshHandUI() 
    {
        base.RefreshHandUI();
        foreach(Transform t in transform) {
            t.GetComponent<Card>().Image.sprite = CardManager.Instance.CardBackSprite;
        }
    }
}
