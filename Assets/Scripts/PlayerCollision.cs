using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    protected int keys = 0;
    protected int points = 0;

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
        }
    }

    void GivePointsAndKeysToPlayer()
    {
        keys += 1;
        points += 1000;
    }
}
