using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float moveSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * (Time.deltaTime * moveSpeed));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * (Time.deltaTime * moveSpeed));
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * (Time.deltaTime * moveSpeed));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * (Time.deltaTime * moveSpeed));
        }
    }
}
