using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    [SerializeField] private int dañoQueRecibeJugador;

    private float tiempoSiguienteDaño;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if (tiempoSiguienteDaño <= 0)
            {
                collision.GetComponent<CombateJugador>().TomarDaño(dañoQueRecibeJugador);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }
}
