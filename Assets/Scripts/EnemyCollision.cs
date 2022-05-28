using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    //Datos que se le pasarán para saber cuanto tiempo queremos que tarde el jugador en recibir daño de un mismo monstruo y 
    //el daño que recibe de dicho monstruo
    [SerializeField] private float tiempoEntreDaño;
    [SerializeField] private int dañoQueRecibeJugador;
    //Esta variable es para saber cuanto tiempo ha pasado entre que ha recibido el daño y el tiempo actual
    private float tiempoSiguienteDaño;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Si el enemigo hace una colisión con el Objeto que tenga la etiqueta Player que será nuestro jugador
        if (collision.CompareTag("Player"))
        {
            //Se le dirá que lo reste del tiempo actual y si es menor o igual a 0 es que ha pasado dicho tiempo y le inflingirá daño
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                //Se le pasará al componente o clase CombateJugador que llamará a tomarDaño y se le pondrá el daño que ha recibido el jugador
                collision.GetComponent<CombateJugador>().TomarDaño(dañoQueRecibeJugador);
                //Luego se le añadirá el tiempo entre el daño al tiempo hasta el siguiguiente daño y así mientras el jugador siga en colisión con el enemigo
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }
}
