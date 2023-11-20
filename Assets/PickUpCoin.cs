using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class PickUpCoin : MonoBehaviour
{
    
    public Text text;

    int CoinCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinCount = Convert.ToInt32(text.text);
            CoinCount++;
            gameObject.SetActive(false);
            //Destroy(gameObject);
            text.text = $"{CoinCount}";
        }
    }
}
