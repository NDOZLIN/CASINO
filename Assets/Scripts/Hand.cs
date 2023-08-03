using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour {
    public List<CardSO> Cards = new List<CardSO>();

    private HorizontalLayoutGroup _horLayout;
    private void Awake() {
        _horLayout = GetComponent<HorizontalLayoutGroup>();
    }

    public virtual void RefreshHandUI() {
  //      _horLayout.enabled = true;
        foreach(Transform t in transform) {
            Destroy(t.gameObject);
        }
        foreach(CardSO c in Cards) {
            GameObject g = Instantiate(CardManager.Instance.CardPrefab, transform);
            g.GetComponent<Card>().Data = c;
            g.GetComponent<Image>().sprite = c.sprite;
            g.transform.GetChild(0).GetComponent<Image>().sprite = c.sprite;
        }
  //      _horLayout.enabled = false;
    }
}
