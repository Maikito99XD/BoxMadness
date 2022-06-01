using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

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
            Destroy(collider.gameObject);
        }
        if (collider.CompareTag("Puerta"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                collider.gameObject.GetComponent<Animator>();
                collider.GetComponent<CombateJugador>().AbrePuerta();
            }
        }
    }

}
