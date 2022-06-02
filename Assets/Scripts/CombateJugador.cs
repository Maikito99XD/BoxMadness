using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombateJugador : MonoBehaviour
{
    //Parametros que podemos pasar para que el jugador tenga una vida y una vida máxima
    [SerializeField] int vida;
    [SerializeField] int maxVida;
    [SerializeField] private AudioSource golpeSoundEffect;
    [SerializeField] private AudioSource openBoxSoundEffect;
    [SerializeField] private AudioSource openDoorSoundEffect;
    private int vidaActualJugador;
    public int llavesJugador = 0;
    private int scoreJugador = 0;
    public Text TXTvidaJugador;
    public Text TXTscore;
    public Text TXTllavesJugador;

    public GameObject reset;
    public GameObject quit;
    public Image gameOver;


    //Al arrancar se le asignará la vida máxima que tendrá el jugador
    void Start()
    {
        vida = maxVida;
        gameOver.enabled = false;
        reset.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
    }

    //El metodo TomarDaño se le pasará el daño que recibe nuestro jugador en cuanto a cierco enemigo,
    //ya que gracias a esto podemos controlar cuando ha perdido el jugador
    public void TomarDaño(int daño)
    {
        if (vida > 0)
        {
            //Se le resta el daño que recibe a la vida actual del jugador
            vida -= daño;
            golpeSoundEffect.Play();
        }
        //Si la vida del jugador es igual o menor a 0 significa que el jugador ha perdido y es un GameOver
        if (vida <= 0)
        {
            vida = 0;
            gameOver.enabled = true;
            reset.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
        }
    }
    public int DevuelveLlaves()
    {
        return llavesJugador;
    }
    public void AbrePuerta()
    {
        llavesJugador -= 1;
        openDoorSoundEffect.Play();
    }
    public void ConsigueLlavesScore(int puntuacion, int llaves)
    {
        llavesJugador += llaves;
        scoreJugador += puntuacion;
        openBoxSoundEffect.Play();
    }

    public void EndGame()
    {
        Application.Quit();
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
