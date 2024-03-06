using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterDropingMoving : MonoBehaviour
{
 
    public AudioSource audioSource;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
        audioSource = GetComponent<AudioSource>();
        player = Camera.main.transform; // Assuming your camera is the player's perspective
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*2*Time.deltaTime);
        float distance = Vector2.Distance(transform.position, player.position);
        float volume = Mathf.Clamp01(1 - distance / 5); // Adjust maxDistance as needed
        audioSource.volume = volume;
    }
}
