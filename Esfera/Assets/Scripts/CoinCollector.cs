using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    //Valor de monedas inicial
    [SerializeField]
    public int coinsObtain = 0;

    //Texto con el contador de COINS
    [SerializeField]
    TextMeshProUGUI labelCoins;


    //Detector de monedas
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            coinsObtain = coinsObtain + 1;
            Debug.Log(coinsObtain);
        }
    }

    private void Update()
    {
        labelCoins.text = coinsObtain.ToString("00") + "/10";
    }
}
