using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacher : MonoBehaviour
{
    //public bool grabbed;
    //RaycastHit2D hit;
    //public float distance = 2f;
    //public Transform holdpoint;

    Collider2D touchingCollider = null;
    //List<Collider> grabableColliders = new List<Collider>();

    private void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if(touchingCollider != null)
            {
                touchingCollider.gameObject.transform.SetParent(this.transform);

            }


            //if (!grabbed)
            //{
                //Physics2D.raycastStartInCollider = false;

                //hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);
                //if (hit.collider != null)
                //{
                //    grabbed = true;
                //}
            }
            //else
            //{

            //}
        //}
        //if (grabbed)
            //hit.collider.gameObject.transform.position = holdpoint.position;
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
