using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public CombateJugador cj;
    public int vidaJugador = 0;
    public int scoreJugador = 0;
    public int llavesJugador = 0;
    public Text TXTscore;
    public Text TXTvidaJugador;
    public Text TXTllavesJugador;

private void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }

    void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag("Box"))
        {
            GivePointsAndKeysToPlayer();
            Destroy(collider.gameObject);
        }
    }

    void GivePointsAndKeysToPlayer()
    {
        llavesJugador++;
        scoreJugador += 1000;
    }

    private void Update()
    {
        TXTscore.text = "Score: " + scoreJugador;
        TXTllavesJugador.text = llavesJugador.ToString();
        TXTvidaJugador.text = vidaJugador.ToString();
    }
}
