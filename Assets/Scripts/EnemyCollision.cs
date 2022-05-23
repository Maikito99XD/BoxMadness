using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDa�o;
    [SerializeField] private int da�oQueRecibeJugador;

    private float tiempoSiguienteDa�o;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tiempoSiguienteDa�o -= Time.deltaTime;
            if (tiempoSiguienteDa�o <= 0)
            {
                collision.GetComponent<CombateJugador>().TomarDa�o(da�oQueRecibeJugador);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }
        }
    }
}
