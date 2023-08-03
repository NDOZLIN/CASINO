using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FourteenDynamics.Extensions;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

public class GeneralManager : MonoBehaviour 
{
    private PlayerHand _pH;
    private AIHand _aH;

    private CardManager _cm;

    public static GeneralManager Instance;

    private void Awake() 
    {
        Instance = this;
    }

    void Start() 
    {
        _pH = FindObjectOfType<PlayerHand>();
        _aH = FindObjectOfType<AIHand>();
        _cm = FindObjectOfType<CardManager>();

        List<CardSO> givenCards = new();
        int x = 0;
        while(x < 10) 
        {
            CardSO c = _cm.AllCards.GetRandom();
            while(givenCards.Contains(c)) 
            {
                c = _cm.AllCards.GetRandom();
            }
            _pH.Cards.Add(c);
            givenCards.Add(c);
            x++;
        }
        x = 0;
        while(x < 10) 
        {
            CardSO c = _cm.AllCards.GetRandom();
            while(givenCards.Contains(c)) 
            {
                c = _cm.AllCards.GetRandom();
            }
            _aH.Cards.Add(c);
            givenCards.Add(c);

            // Add the cards to the AI's hand
            _aH.GetComponent<SimpleAI>().AddCardToHand(c);

            x++;
        }
        _pH.RefreshHandUI();
        _aH.RefreshHandUI();

        // Simulate the AI making a decision after all the cards are dealt
        _aH.GetComponent<SimpleAI>().MakeDecision();
    }


    public Card PlayerHandCard = null;
    public void ClickedCard(Card card) 
    {
        if(PlayerHandCard == null) 
        {
            PlayerHandCard = card;
        } 
        else 
        {
            PlayerHandCard.IsSelected = false;
            PlayerHandCard = card;
        }
        PlayerHandCard.IsSelected = true;
    }

    public void ClickedCardSpot(CardSpot cs) 
    {
        if(cs.SpotType == SpotType.Table) 
        {
            if(cs.CurrentCard == null) 
            {
                if(PlayerHandCard != null) 
                {
                    // switch card
                    PlayerHandCard.IsPlayerHandCard = false;
                    PlayerHandCard.IsTableCard = true;
                    PlayerHandCard.IsSelected = false;
                    // Get the position of the card spot
                    Vector3 cardSpotPosition = cs.CardSpotPosition;
                    Debug.Log("Card spot position: " + cardSpotPosition);

                    cs.ShowCard(PlayerHandCard);
                    PlayerHandCard = null;
                }
            }
        }
    }
}
