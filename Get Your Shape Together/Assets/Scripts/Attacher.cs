using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacher : MonoBehaviour
{
    Collider2D touchingCollider = null;
    List<Collider2D> grabableColliders = new List<Collider2D>();

    public List<GameObject> attachedShapes = new List<GameObject>();
    private int Shapegoal;

    private void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(touchingCollider != null && touchingCollider.gameObject != this.gameObject)
            {
                if (attachedShapes.Contains(touchingCollider.gameObject) == false) 
                {
                    Destroy(touchingCollider.attachedRigidbody);
                
                    touchingCollider.gameObject.transform.SetParent(this.transform);

                    attachedShapes.Add(touchingCollider.gameObject);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (touchingCollider != null)
            {
                foreach (GameObject go in attachedShapes)
                {
                    Rigidbody2D rb = go.AddComponent<Rigidbody2D>();
                    rb.isKinematic = true;
                    go.transform.SetParent(null);
                }
                attachedShapes.Clear();
                //transform.DetachChildren();

            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "grabbable")
        {
            Debug.Log("ENTER!");
            touchingCollider = other;
            //if(grabableColliders.Contains(other) == false)
            //{
            //    grabableColliders.Add(other);
            //}
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "grabbable")
        {
            Debug.Log("EXIT!");
            touchingCollider = null;
            //if (grabableColliders.Contains(other) == true)
            //{
            //    grabableColliders.Remove(other);
            //}
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "grabbable")
        {

            Shapegoal++;
            
        }
        if (Shapegoal >= 3)
        {
            Debug.Log("Loaded!");
            Application.LoadLevel("Credits");
        }
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Collider2D other = collision.otherCollider;
    //    if (other.gameObject.tag == "grabbable")
    //    {
    //        Debug.Log("ENTER!");
    //        touchingCollider = other;
    //        //if(grabableColliders.Contains(other) == false)
    //        //{
    //        //    grabableColliders.Add(other);
    //        //}
    //    }
    //}
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    Collider2D other = collision.otherCollider;
    //    if (other.gameObject.tag == "grabbable")
    //    {
    //        Debug.Log("EXIT!");
    //        touchingCollider = null;
    //        //if (grabableColliders.Contains(other) == true)
    //        //{
    //        //    grabableColliders.Remove(other);
    //        //}
    //    }
    //}
}
