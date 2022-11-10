using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesRotation : MonoBehaviour
{
    //Rotacion de los Obtáculos
    [SerializeField]
    float rotationY = 50f;

    //Funcion de rotacion de los Obstáculos
    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0.0f);
    }
}
