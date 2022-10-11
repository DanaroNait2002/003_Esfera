using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    //Rotacion de las COINS
    [SerializeField]
    float rotationX = 50f;

    //Funcion de rotacion de las COINS
    void Update()
    {
        transform.Rotate(rotationX * Time.deltaTime, 0.0f, 0.0f);
    }
}
