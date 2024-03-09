using UnityEngine;
using UnityEngine.Events;

public class drag_trash : MonoBehaviour
{
    private bool isBeingDragged = false;
    private Vector3 initialPosition;

    /* public UnityEvent OnTrashPlacedCorrectly;
     public UnityEvent OnTrashPlacedIncorrectly;
    */
    void OnMouseDown()
    {
        isBeingDragged = true;
        initialPosition = transform.position;
    }

    void OnMouseDrag()
    {
        if (isBeingDragged)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPosition.z = transform.position.z; // Maintain the same Z position
            transform.position = newPosition;
        }
    }

    void OnMouseUp()
    {
        isBeingDragged = false;

        // Check if there is a collider at the current position
        /*Collider2D collider = Physics2D.OverlapPoint(transform.position);

        if (collider != null)
        {
            // Check if the collider has the tag "TrashTank"
            if (collider.CompareTag("TrashTank"))
            {
                print("Object collided with TrashTank!");

                // Destroy the game object
                Destroy(gameObject);
            }
            else
            {
                // If collider has a different tag, reset object's position
                transform.position = initialPosition;
            }
        }
        else
        {
            // If no collider found, reset object's position
            transform.position = initialPosition;
        }*/
    }


}
