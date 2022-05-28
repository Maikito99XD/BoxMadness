using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombateJugador : MonoBehaviour
{
    //Parametros que podemos pasar para que el jugador tenga una vida y una vida máxima
    [SerializeField] int vida;
    [SerializeField] int maxVida;
    private int vidaActualJugador;
    private int llavesJugador = 0;
    private int scoreJugador = 0;
    public Text TXTvidaJugador;
    public Text TXTscore;
    public Text TXTllavesJugador;

    public GameObject reset;
    public Image gameOver;

    //Al arrancar se le asignará la vida máxima que tendrá el jugador
    void Start()
    {
        vida = maxVida;
        gameOver.enabled = false;
        reset.gameObject.SetActive(false);
    }

    //El metodo TomarDaño se le pasará el daño que recibe nuestro jugador en cuanto a cierco enemigo,
    //ya que gracias a esto podemos controlar cuando ha perdido el jugador
    public void TomarDaño(int daño)
    {
        //Se le resta el daño que recibe a la vida actual del jugador
        vida -= daño;
        //Si la vida del jugador es igual o menor a 0 significa que el jugador ha perdido y es un GameOver
        if (vida <= 0)
        {
            Destroy(gameObject);
            reset.gameObject.SetActive(true);
            Debug.Log("He llegado");
            gameOver.enabled = true;
        }
    }
    public void consigueLlavesScore(int puntuacion, int llaves)
    {
        llavesJugador += llaves;
        scoreJugador += puntuacion;
    }
    // Update is called once per frame
    void Update()
    {
        vidaActualJugador = vida;
        TXTvidaJugador.text = ""+vidaActualJugador;
        TXTscore.text = "Score: "+scoreJugador;
        TXTllavesJugador.text = "" + llavesJugador;
    }
}
