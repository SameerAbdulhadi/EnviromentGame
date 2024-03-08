using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadStepOne : MonoBehaviour
{
    public void LoadNextScene()
    {
       
        SceneManager.LoadScene("treatment-1");
       
    }
}
