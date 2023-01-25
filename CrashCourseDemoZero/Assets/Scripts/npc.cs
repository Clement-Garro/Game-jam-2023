using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class npc : MonoBehaviour
{
    public GameObject chat;
    public Text Text;
    public GameObject continueButton;
    public string[] dialogue;
    private int index;

    public float wordSpeed;
    public bool playerIsClose;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playerIsClose)
        {
            if (chat.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                chat.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        
        if (Text.text == dialogue[index])
        {
            continueButton.SetActive(true);
        }
        else
        {
            continueButton.SetActive(false);
        }
    }
    
    public void zeroText()
    {
        Text.text = "";
        index = 0;
        chat.SetActive(false);
    }
    
    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            Text.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }
    
    public void NextLine()
    {
        continueButton.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            Text.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }
}
