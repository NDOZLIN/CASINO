using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    private List<CardSO> aiHand = new List<CardSO>();

    // Method to add a card to the AI's hand
    public void AddCardToHand(CardSO card)
    {
        aiHand.Add(card);
    }

    // Method to remove a card from the AI's hand
    public void RemoveCardFromHand(CardSO card)
    {
        aiHand.Remove(card);
    }

    // Method to simulate the AI making a decision
    public void MakeDecision()
    {
        if (aiHand.Count > 0)
        {
            // Choose a random card to play from the AI's hand
            int randomIndex = Random.Range(0, aiHand.Count);
            CardSO cardToPlay = aiHand[randomIndex];

            // Remove the card from the AI's hand
            aiHand.RemoveAt(randomIndex);

            // Play the card on the table
            PlayCardOnTable(cardToPlay);
        }
        else
        {
            Debug.Log("AI Hand is empty. Cannot make a decision.");
        }
    }

    // Method to play the selected card on the table
    private void PlayCardOnTable(CardSO card)
    {
        // In this example, we'll simply log the card played by the AI
        Debug.Log("AI played: " + card.rank + " of " + card.suit);

        // Here, you can add your game logic to place the card on the table, update game state, etc.
        // For example, you may need to instantiate a card GameObject on the table and set its properties.
        // The implementation will depend on your specific game mechanics.

        // After playing the card, the AI will make another decision (simulate AI's turn)
        StartCoroutine(MakeDecisionCoroutine());
    }

    // Coroutine to simulate a delay before the AI makes another decision
    private IEnumerator MakeDecisionCoroutine()
    {
        // You can add a delay here to make the AI's actions more human-like
        yield return new WaitForSeconds(1f); // Adjust the delay duration as needed

        // Call the MakeDecision method again to continue AI's turn
        MakeDecision();
    }
}


