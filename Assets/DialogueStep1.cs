using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueStep1 : MonoBehaviour
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
        StartCoroutine(StartDialogueWithDelay());
    }

    IEnumerator StartDialogueWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeStart);
        StartDialogue();
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

    public void LoadNextScene()
    {
        // Load the next scene by its index or name
        SceneManager.LoadScene("factory");
        // If you want to load the next scene by index, use SceneManager.LoadScene(index);
    }
}
