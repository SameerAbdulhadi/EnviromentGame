using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enteringFactory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    
        void Update()
        {
            // Check for mouse click
            if (Input.GetMouseButtonDown(0))
            {
                // Check if the mouse click is over this object
                Collider2D collider = GetComponent<Collider2D>();
                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (collider.OverlapPoint(mousePosition))
                {
                    SceneManager.LoadScene("factory (2)");
                }
            }
        }
    }

   

