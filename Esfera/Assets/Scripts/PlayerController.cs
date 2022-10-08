using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //IMPULSO PENDIENTE POR HACER :(

    //MOVEMENT cosas

        //Variables de Movimiento
        Vector3 direction;
    
        //Constante de impulso
        [SerializeField]
        public float impulse = 5f;


    //TIME cosas

        //TIME jugado
        [SerializeField]
        float timer = 60.0f;

        //Texto TIMER
        [SerializeField]
        TextMeshProUGUI labelTimer;

    //GAME OVER cosas

    //Texto GAME OVER
        [SerializeField]
        GameObject screemGameOver;
        



    void Update()
    {
        //MOVEMENT cosas

            //Valor de Movimiento en el Mando/Teclado
            direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * impulse;
            direction.z = Input.GetAxis("Vertical") * Time.deltaTime * impulse;
            transform.Translate(direction);


        //TIME cosas

            //Restar tiempo transcurrido de partida
            timer -= 1f * Time.deltaTime;
            labelTimer.text = timer.ToString("00.0");

            //Acabar juego si se acaba el tiempo
            if (timer <= 0.0f)
            {
                timer = 0.0f;
                this.enabled = false;
                screemGameOver.SetActive(true);
            }
    }
}