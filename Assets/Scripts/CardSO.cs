using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

[CreateAssetMenu(fileName = "Card")]
public class CardSO : ScriptableObject 
{
    public Rank rank;
    public Suit suit;
    public Sprite sprite;
}

public enum Rank 
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10
}

public enum Suit 
{
    Heart,
    Diamond,
    Club,
    Spade
}