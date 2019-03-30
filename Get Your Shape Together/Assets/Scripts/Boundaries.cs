using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{

 

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
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
