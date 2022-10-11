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

    //COINS cosas

        //Valor de COIN inicial
        [SerializeField]
        public int coinsObtain = 0;

        //Texto con el contador de COINS
        [SerializeField]
        TextMeshProUGUI labelCoins;

        //PARTICLES de EXPLOSIÓN 
        [SerializeField]
        GameObject prefabsParticles;

    //GAME OVER cosas

        //Texto GAME OVER LOST
        [SerializeField]
        GameObject screemGameOverLost;

        //Texto GAME OVER WIN   
        [SerializeField]
        GameObject screemGameOverWin;



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
                screemGameOverLost.SetActive(true);
            }

        //COINS cosas

            //Texto con contador de COINS
            labelCoins.text = coinsObtain.ToString("00") + "/10";

            //Acabar juego si se conseguen todas las monedas
            if (coinsObtain == 30)
            {
                this.enabled = false;
                screemGameOverWin.SetActive(true);
            }
    }

    //COINS cosas

        //Detector de COINS
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Coin")
            {
                //Desactivar COINS
                other.gameObject.SetActive(false);

                //Sumar una COIN
                coinsObtain += 1;
            
                //Crear particulas de EXPLOSIÓN
                Instantiate(prefabsParticles, other.transform.position, other.transform.rotation);
            }
        }

}