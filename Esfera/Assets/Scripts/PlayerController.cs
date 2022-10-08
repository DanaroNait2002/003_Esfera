using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables de Movimiento
    Vector3 direction;

    //Constante de impulso
    [SerializeField]
    float impulse = 5f;


    void Update()
    {
        //Valor de Movimiento en el Mando/Teclado
        direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * impulse;
        direction.z = Input.GetAxis("Vertical") * Time.deltaTime * impulse;
        transform.Translate(direction);
    }
}