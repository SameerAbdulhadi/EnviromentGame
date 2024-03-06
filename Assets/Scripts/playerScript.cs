using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class playerScript : MonoBehaviour
{
    public GameObject dialougePanel;
    public Text dialougeText;
    public string[] dialogue;
    private int index;

    public GameObject coneButton;
    public float wordSpeed;
    public bool playerIsClose;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WaterTabMission"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Tap"))
        {
            playerIsClose = false;
            ZeroText();
        }
    }
    
    public  void nextLine()
    {
        coneButton.SetActive(false);
        if(index < dialogue.Length - 1)
        {
            index++;
            dialougeText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            ZeroText();
        }

    }
   void ZeroText()
    {
        dialougeText.text = " ";
        dialougePanel.SetActive(false);
        index = 0;
    }
    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialougeText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& playerIsClose)
        {
            if (dialougePanel.activeInHierarchy)
            {
                ZeroText();
            }
            else
            {
                dialougePanel.SetActive(true);
                StartCoroutine(Typing());
                
            }
        }
        if(dialougeText.text == dialogue[index])
        {
            coneButton.SetActive(true);
        }
    }
}
