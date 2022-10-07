using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables de Movimiento
    //public float movementX;
    //public float movementY;
    //public float movementZ;
    //Rigidbody body;
    Vector3 direction;

    //Constante de impulso
    [SerializeField]
    float impulse = 5f;


    //Constante de Velocidad
    [SerializeField]
    //float velocidadMovimiento = 1.5f;

    void Update()
    {
        //Valor de Movimiento en el Mando/Teclado
        //movementX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        //movementZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        //transform.Translate(movementX, movementY, movementZ);
        //Obtengo datos de movimiento en el mando/teclado
        direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * impulse;
        direction.z = Input.GetAxis("Vertical") * Time.deltaTime * impulse;
        transform.Translate(direction);
    }

    private void FixedUpdate()
    {
        //Empujo hacia donde se mueve
        //body.AddForce(direction, ForceMode.Impulse);
    }
}