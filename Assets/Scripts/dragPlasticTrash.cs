using UnityEngine;
using UnityEngine.Events;

public class dragPlasticTrash : MonoBehaviour
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

        Collider2D collider = Physics2D.OverlapPoint(transform.position);

        if (collider != null)
        {
            if (collider.gameObject.name == "plasticTrash")
            //OnTrashPlacedCorrectly.Invoke();
            {
                Destroy(gameObject);

            }

            else
            {
                //OnTrashPlacedIncorrectly.Invoke();
                transform.position = initialPosition;
            }
        }
        else
        {
            transform.position = initialPosition;
        }

        
    }
}
