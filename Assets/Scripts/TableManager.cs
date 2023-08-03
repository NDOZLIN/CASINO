using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableManager : MonoBehaviour
{
    /*public void StackCardsByRank(List<CardSO> cards)
    {
       // adding cards by rank
    }

    public void StackCardsOnTable(Card card1, Card card2, CardSpot targetSpot)
    {
        // Checking if both cards are from the table
        bool areBothTableCards = card1.IsTableCard && card2.IsTableCard;

        // Checking if the cards are stackable based on your game logic
        //bool areCardsStackable = determining if the cards can be stacked;

        if (areBothTableCards /*&& areCardsStackable)
        {
            // Combining the data of the two cards into a new card
            CardSO combinedCardData = CombineCardData(card1.Data, card2.Data);

            // Create a new card game object representing the combined card
            GameObject newCardObject = Instantiate(CardManager.Instance.CardPrefab, targetSpot.transform);

            // Get the Card component from the new card game object
            Card newCard = newCardObject.GetComponent<Card>();

            // Assign the combined card data to the new card
            newCard.Data = combinedCardData;

            // Update the card UI with the new data
            newCard.Image.sprite = combinedCardData.sprite;
            newCard.transform.GetChild(0).GetComponent<Image>().sprite = combinedCardData.sprite;

            // Destroy the original cards
            Destroy(card1.gameObject);
            Destroy(card2.gameObject);
        }
    }

    // Helper method to combine card data
    private CardSO CombineCardData(CardSO card1, CardSO card2)
    {
        // Create a new CardSO with combined values.
        // Decide what happens when the cards are stacked.
        
        return card1;
    }*/
}

