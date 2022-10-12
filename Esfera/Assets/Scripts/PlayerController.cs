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
        float timePlayed = 0.0f;

        //Texto TIMEPLAYED
        [SerializeField]
        TextMeshProUGUI labelTimePlayed;

        //Texto TIMEPLAYED resultado
        [SerializeField]
        TextMeshProUGUI labelTimePlayedResult;

    //COINS cosas

        //Valor de COIN inicial
        [SerializeField]
        public int coinsObtain = 0;

        //Texto con el contador de COINS
        [SerializeField]
        TextMeshProUGUI labelCoins;

        //Texto con el contador de COINS total
        [SerializeField]
        TextMeshProUGUI labelCoinsResult;

        //PARTICLES de EXPLOSIÓN 
        [SerializeField]
        GameObject prefabsParticles;

    //GAME OVER cosas

        //Texto GAME OVER WIN   
        [SerializeField]
        GameObject screemGameOverWin;
        
        //Canvas Texto TIME in game
        [SerializeField]
        GameObject screemCoinsInGame;

        //Canvas Texto COINS in game
        [SerializeField]
        GameObject screemTimeInGame;



    void Update()
    {
        //MOVEMENT cosas

            //Valor de Movimiento en el Mando/Teclado
            direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * impulse;
            direction.z = Input.GetAxis("Vertical") * Time.deltaTime * impulse;
            transform.Translate(direction);


        //TIME cosas

            //Sumar tiempo jugado a la partida
            timePlayed += 1 * Time.deltaTime;
            labelTimePlayed.text = timePlayed.ToString("00.0");
            labelTimePlayedResult.text = timePlayed.ToString("00.0");

        //COINS cosas

            //Texto con contador de COINS
            labelCoins.text = coinsObtain.ToString("00") + "/30";
            labelCoinsResult.text = coinsObtain.ToString("00") + "/30";

            //Acabar juego si se conseguen todas las monedas
            if (coinsObtain == 30)
            {
                this.enabled = false;
                screemGameOverWin.SetActive(true);
                screemCoinsInGame.SetActive(false);
                screemTimeInGame.SetActive(false);
                    
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