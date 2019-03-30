using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public KeyCode pressUp;
    public KeyCode pressDown;
    public KeyCode pressLeft;
    public KeyCode pressRight;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(pressUp))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(pressDown))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 180);
        if (Input.GetKeyDown(pressLeft))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 90);
        if (Input.GetKeyDown(pressRight))
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, -90);

    }
}
