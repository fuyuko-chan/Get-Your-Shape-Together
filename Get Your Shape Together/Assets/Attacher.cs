using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacher : MonoBehaviour
{
    void setDrop()
    {
        // Remove Item from player parent 
        Pickup.transform.parent = null;
        pickedItem.rigidbody2D.isKinematic = true;

        //Set New Position to drop item
        float newY, newX;
        if (playerLookY == -1)
        {
            // Looking up: Use Player Collider Size + Y position
            newY = (transform.collider2D.bounds.size.y + 0.02f) * -1F;
        }
        else if (playerLookY == 1)
        {
            // Looking down: Use item Collider Size + Y position
            newY = pickedItem.collider2D.bounds.size.y + 0.02f;
        }
        else
        {
            // Adjust object to the player foot
            newY = (transform.collider2D.bounds.size.y - pickedItem.collider2D.bounds.size.y) * -1;
        }
        // Since X collider is in X = 0, the logis is simplier
        newX = (pickedItem.collider2D.bounds.size.x + 0.02f) * playerLookX;
        //Set New Position to drop item
        pickedItem.rigidbody2D.position =
            new Vector2(
                (transform.position.x + newX),
                (transform.position.y + newY)
            );

        // Adjust Object Layer
        pickedItem.GetComponent<SpriteRenderer>().sortingLayerName = "Player";
        // Adjust Object Order
        pickedItem.GetComponent<SpriteRenderer>().sortingOrder = (int)((10 * ((transform.position.y + (playerLookY * 0.25f)) * -1)));
        // Set no item is picked
        pickedItem = null;
        picking = false;
    }
}
