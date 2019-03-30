using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.1f;
    public float moveSpeed;

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

        // allows collsion with objects with collider
       Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")); 

     

    }


}
