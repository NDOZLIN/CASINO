using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour, IPointerDownHandler 
{
    public CardSO Data;

    public bool IsPlayerHandCard = false;
    public bool IsTableCard = false;

    public Image Image 
    {
        get 
        {
            return GetComponent<Image>();
        }
    }

    private bool _isSelected = false;
    public bool IsSelected 
    {
        get 
        {
            return _isSelected;
        }
        set 
        {
            transform.GetChild(0).GetComponent<Image>().enabled = value;
            GetComponent<Image>().enabled = !value;
            _isSelected = value;
        }
    }

    public void OnPointerDown(PointerEventData eventData) 
    {
            GeneralManager.Instance.ClickedCard(this);

            // Display a message in the console with card information and position
            string cardInfo = IsTableCard ? "Table Card" : "Player Hand Card";
            Debug.Log($"Clicked Card: {Data.rank} of {Data.suit} | Position: {transform.position} | {cardInfo}");
    }
}
