using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSpot : MonoBehaviour, IPointerDownHandler 
{
    public Card CurrentCard = null;
    public SpotType SpotType;

    // Unique identifier for each card spot
    public string SpotID;

    // Expose the position of the card spot
    public Vector3 CardSpotPosition => transform.position;

    public void OnPointerDown(PointerEventData eventData) 
    {
        // Print a message in the console when the card spot is clicked
        Debug.Log($"Card spot '{SpotID}' clicked!");

        GeneralManager.Instance.ClickedCardSpot(this);
    }

    public void ShowCard(Card card) 
    {
        card.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        card.GetComponent<RectTransform>().SetParent(transform);
        CurrentCard = card;
    }
}

public enum SpotType 
{
    Table
}
