using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class area1Button : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue = {
        "Welcome to the game!",
        "This is a simple dialogue example.",
        "You can customize it as per your requirements."
    };
    private int index;

    public Button coneButton; // Changed from GameObject to Button

    public float wordSpeed = 0.1f; // Adjust this value as needed
    public float delayBeforeStart = 3f; // Delay before starting the dialogue

    void Start()
    {
        dialoguePanel.SetActive(false); // Deactivate dialogue panel at start
        coneButton.interactable = false; // Set button as non-interactable initially
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
        coneButton.interactable = false; // Set button as non-interactable when dialogue starts
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
        coneButton.interactable = true; // Set button as interactable after dialogue is finished typing
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
            coneButton.interactable = false; // Set button as non-interactable when typing next line
        }
    }
}
