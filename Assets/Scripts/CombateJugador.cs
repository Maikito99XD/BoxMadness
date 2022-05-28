using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombateJugador : MonoBehaviour
{
    //Parametros que podemos pasar para que el jugador tenga una vida y una vida m�xima
    [SerializeField] int vida;
    [SerializeField] int maxVida;
    private int vidaActualJugador;
    private int llavesJugador = 0;
    private int scoreJugador = 0;
    public Text TXTvidaJugador;
    public Text TXTscore;
    public Text TXTllavesJugador;

    //Al arrancar se le asignar� la vida m�xima que tendr� el jugador
    void Start()
    {
        vida = maxVida;
    }

    //El metodo TomarDa�o se le pasar� el da�o que recibe nuestro jugador en cuanto a cierco enemigo,
    //ya que gracias a esto podemos controlar cuando ha perdido el jugador
    public void TomarDa�o(int da�o)
    {
        //Se le resta el da�o que recibe a la vida actual del jugador
        vida -= da�o;
        //Si la vida del jugador es igual o menor a 0 significa que el jugador ha perdido y es un GameOver
        if (vida <= 0)
        {
            Destroy(gameObject);
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
