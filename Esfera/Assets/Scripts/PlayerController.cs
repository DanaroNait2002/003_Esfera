using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Variables de Movimiento
    public float movementX;
    public float movementY;
    public float movementZ;

    //Constante de Velocidad
    [SerializeField]
    float velocidadMovimiento = 1.5f;

    void Update()
    {
        //Valor de Movimiento en el Mando/Teclado
        movementX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movementZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movementX, movementY, movementZ);
    }
}