using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogue2 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue = {
        "Welcome to the game!",
        "This is a simple dialogue example.",
        "You can customize it as per your requirements."
    };
    private int index;

    // public GameObject coneButton;
    public float wordSpeed = 0.1f; // Adjust this value as needed
    public float delayBeforeStart = 3f; // Delay before starting the dialogue

    void Start()
    {
        //coneButton.SetActive(false);
        StartCoroutine(StartDialogueWithDelay());
        StartCoroutine(ReturnToFactoryAfterDelay());
    }




    IEnumerator ReturnToFactoryAfterDelay()
    {
        // Wait for some time before returning to the factory scene
        yield return new WaitForSeconds(30f); // Adjust the delay time as needed (5 seconds in this example)

        // Load the factory scene
        SceneManager.LoadScene("factory (2)");
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
        //coneButton.SetActive(true);
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
