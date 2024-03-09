using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToFactory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ReturnToFactoryAfterDelay());
    }

    IEnumerator ReturnToFactoryAfterDelay()
    {
        // Wait for some time before returning to the factory scene
        yield return new WaitForSeconds(5f); // Adjust the delay time as needed (5 seconds in this example)

        // Load the factory scene
        SceneManager.LoadScene("FactoryScene");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene222()
    {
        print("ddddddddd");
        SceneManager.LoadScene("MAP");
    }
}
