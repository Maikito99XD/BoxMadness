using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PuertaController : MonoBehaviour
{
    private CombateJugador combateJugador;
    private PlayableDirector playable;
    private bool validado = false;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            combateJugador = collision.GetComponent<CombateJugador>();
            Debug.Log("He llegado");
            if (combateJugador.llavesJugador > 0 )
            {
                Debug.Log("He entrado");
              
                if (validado)
                {
                    AnimacionPuerta();
                }
            }
        }
    }
    public void AnimacionPuerta()
    {
        Destroy(gameObject);
    }
}
