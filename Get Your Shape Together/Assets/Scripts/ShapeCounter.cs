using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> attachedShapes = new List<GameObject>();
    int sizeOfList;

    void Start()
    {
        sizeOfList = attachedShapes.Count;
        if (sizeOfList == 3)
        {
            Application.Quit();
        }
    }      

    // Update is called once per frame
    void Update()
    {

        
    }
}
