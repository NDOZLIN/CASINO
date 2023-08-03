using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour 
{
    [SerializeField] private float _startTimer;
    private void Start() 
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer() 
    {
        yield return new WaitForSeconds(_startTimer);
        FindObjectOfType<GeneralManager>().enabled = true;
    }
}
