using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxCollision : MonoBehaviour
{
    [SerializeField] private int cantidadLlaves;
    [SerializeField] private int cantidadPuntos;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<CombateJugador>().ConsigueLlavesScore(cantidadPuntos, cantidadLlaves);
            Destroy(gameObject);
        }
    }

}
