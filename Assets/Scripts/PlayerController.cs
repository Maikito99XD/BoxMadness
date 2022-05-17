using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime,0));
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
        }

        if (Input.GetKeyDown("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f * Time.deltaTime));
        }

        if (Input.GetKeyDown("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1000f * Time.deltaTime));
        }

    }
}
