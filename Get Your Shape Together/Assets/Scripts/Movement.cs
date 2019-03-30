using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.1f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 position = transform.position;
            position.x += speed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 position = transform.position;
            position.x -= speed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 position = transform.position;
            position.y += speed;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 position = transform.position;
            position.y -= speed;
            transform.position = position;
        }
        // border X axis
        if (transform.position.x <= -11.9f)
        {
            transform.position = new Vector2(-11.9f, transform.position.y);
        }
        else if (transform.position.x >= 11.9f)
        {
            transform.position = new Vector2(11.9f, transform.position.y);
        }

        // border Y axis
        if (transform.position.y <= -4.8f)
        {
            transform.position = new Vector2(transform.position.x, -4.8f);
        }
        else if (transform.position.y >= 4.8f)
        {
            transform.position = new Vector2(transform.position.x, 4.8f);
        }




    }
}
       



 
