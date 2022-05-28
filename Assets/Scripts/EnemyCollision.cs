using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    //Datos que se le pasar�n para saber cuanto tiempo queremos que tarde el jugador en recibir da�o de un mismo monstruo y 
    //el da�o que recibe de dicho monstruo
    [SerializeField] private float tiempoEntreDa�o;
    [SerializeField] private int da�oQueRecibeJugador;
    //Esta variable es para saber cuanto tiempo ha pasado entre que ha recibido el da�o y el tiempo actual
    private float tiempoSiguienteDa�o;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Si el enemigo hace una colisi�n con el Objeto que tenga la etiqueta Player que ser� nuestro jugador
        if (collision.CompareTag("Player"))
        {
            //Se le dir� que lo reste del tiempo actual y si es menor o igual a 0 es que ha pasado dicho tiempo y le inflingir� da�o
            tiempoSiguienteDa�o -= Time.deltaTime;
            if (tiempoSiguienteDa�o <= 0)
            {
                //Se le pasar� al componente o clase CombateJugador que llamar� a tomarDa�o y se le pondr� el da�o que ha recibido el jugador
                collision.GetComponent<CombateJugador>().TomarDa�o(da�oQueRecibeJugador);
                //Luego se le a�adir� el tiempo entre el da�o al tiempo hasta el siguiguiente da�o y as� mientras el jugador siga en colisi�n con el enemigo
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }
        }
    }
}
