using UnityEngine;

public class RespawnAtPoint : MonoBehaviour
{
    public Transform respawnPoint;  // The point from which the object should respawn

    // Function to respawn the object
    public void Respawn()
    {
        if (respawnPoint != null)
        {
            // Set the object's position to the respawn point
            transform.position = respawnPoint.position;
        }
        else
        {
            Debug.LogWarning("Respawn point not assigned in RespawnAtPoint script for object: " + gameObject.name);
        }
    }
}
