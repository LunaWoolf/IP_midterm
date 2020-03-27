using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    //——————————————————————————————————————————————————————————————————————————Dialogue Set up
    public Text nameText;
    public Text diaText;
    public Dialogue dialogue;
    public Queue<string> sentences;
    public GameObject continuebutton;
    public GameObject choices;
    public Animator boxAnimator;
    public bool open;
    public GameObject characterimage01;
    public GameObject characterimage02;

    void Start()
    {
        choices.SetActive(false);
        sentences = new Queue<string>();
    }


    public void startDialogue(Dialogue dialogue)
    {
        //————————————————————————————————————————————————————————————————-———— set up
        sentences = new Queue<string>();
        nameText.enabled = true;
        diaText.enabled = true;
        continuebutton.SetActive(true);
        this.dialogue = dialogue;
        open = true;
        boxAnimator.SetBool("isOpen", true);
        nameText.text = dialogue.name;
        characterimagedisplay();

        //——————————————————————————————————————————————————————————————————————Enqueue Sentence
        foreach (string sentence in dialogue.sentence)
        {
            sentences.Enqueue(sentence);
        }

        //displayNextSentence();
        string curSentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(curSentence));
    }

    public void displayNextSentence()
    {
        
        if (sentences.Count == 0)
        {
            endDialogue(dialogue);
            return;
        }

        string curSentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(curSentence));

    }

    //——————————————————————————————————————————————————————————————————————————Typing animation
    IEnumerator TypeSentence(string sentence)
    {
        diaText.text = "";
        foreach (char letter in sentence)
        {
            diaText.text += letter;
            yield return null;
        }
    }

    public void endDialogue(Dialogue dialogue)
    {


        if (!dialogue.hasquestion)
        {
          
            boxAnimator.SetBool("isOpen", false);
            open = false;
            characterimage01.SetActive(false);
            characterimage02.SetActive(false);
        }

        if (dialogue.hasquestion)
        {
            loadquestion(dialogue);
        }

        if (dialogue.nextdialogue != null)
        {
            startDialogue(dialogue.nextdialogue);
        }
    }


    public void loadquestion(Dialogue dialogue)
    {
        nameText.enabled = false;
        diaText.enabled = false;
        continuebutton.SetActive(false);

        choices.SetActive(true);
        choices.transform.Find("Question").GetComponent<Text>().text = dialogue.question.que;
        choices.transform.Find("Choi01").GetComponentInChildren<Text>().text = dialogue.question.Choice[0].choice;
        if (dialogue.question.Choice.Length > 1)
        {
            choices.transform.Find("Choi02").gameObject.SetActive(true);
            choices.transform.Find("Choi02").GetComponentInChildren<Text>().text = dialogue.question.Choice[1].choice;

        }
        else
            choices.transform.Find("Choi02").gameObject.SetActive(false);
    }

    public void runNextDialogue(int num)
    {
        if (dialogue.question.Choice[num].image != null)
        {

            dialogue.question.Choice[num].image.GetComponent<Animator>().SetTrigger("appears");
        }

        choices.SetActive(false);
        if (dialogue.question.Choice[num].nextDialogue != null)
        {
            dialogue.question.Choice[num].nextDialogue.GetComponent<DialogueTrigger>().TriggerDialogue();

        }
        else
        {
            boxAnimator.SetBool("isOpen", false);
            open = false;
        }

        characterimage01.SetActive(false);
        characterimage02.SetActive(false);
    }

    public void characterimagedisplay()
    {
        if (dialogue.characterimage01)
        { 
            characterimage01.SetActive(true);
        }

        if (dialogue.characterimage02)
        {
            characterimage02.SetActive(true);
        }
    }
}
