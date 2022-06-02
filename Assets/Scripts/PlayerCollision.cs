using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public bool puertaEntrada = false;
    private PuertaController puerta;
    [SerializeField] CombateJugador combateJugador;
    private int llaves;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            
        }

        if (collision.CompareTag("Puerta"))
        {
            puertaEntrada = true;
            puerta = collision.GetComponent<PuertaController>();
        }
    }
    void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag("Box"))
        {
            
        }
        
        if (collider.CompareTag("Puerta"))
        {
            puertaEntrada = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Puerta"))
        {
            puertaEntrada = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (puertaEntrada == true)
            {
                llaves = combateJugador.DevuelveLlaves();
                if (llaves > 0)
                {
                    combateJugador.AbrePuerta();
                    puerta.AnimacionPuerta();
                }
            }
        }
    }
}
