using UnityEngine;

public class MoveUpward : MonoBehaviour
{
    public float speed = 2f;  // Speed of upward movement
    private Rigidbody2D rb; // Rigidbody component of the object

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody2D>();

        // Apply initial upward velocity
        rb.velocity = Vector2.up * speed;
    }
}
