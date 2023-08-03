using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour {
    public GameObject CardPrefab;
    public Sprite CardBackSprite;
    public List<CardSO> AllCards = new List<CardSO>();

    public static CardManager Instance;

    private void Awake() {
        Instance = this;
    }
    // Add methods for shuffling, dealing, etc
}
