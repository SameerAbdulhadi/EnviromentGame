using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class area3Button : MonoBehaviour
{


    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue = {
        "Welcome to the game!",
        "This is a simple dialogue example.",
        "You can customize it as per your requirements."
    };
    private int index;

    public GameObject coneButton;
    public float wordSpeed = 0.1f; // Adjust this value as needed
    public float delayBeforeStart = 3f; // Delay before starting the dialogue



    void Start()
    {
        coneButton.SetActive(false);
    }




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
                StartDialogue();
            }
        }
    }



    void StartDialogue()
    {
        dialoguePanel.SetActive(true);
        StartCoroutine(Typing());
    }

    void ZeroText()
    {
        dialogueText.text = " ";
        index = 0;
    }

    IEnumerator Typing()
    {
        dialogueText.text = ""; // Clear the dialogue text before typing the new line
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }

        // Dialogue fully typed out, activate the cone button
        coneButton.SetActive(true);
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
    }


}








