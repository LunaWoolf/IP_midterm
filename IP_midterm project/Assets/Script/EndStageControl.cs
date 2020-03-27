using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This class control the end stage's score and text display
public class EndStageControl : MonoBehaviour
{
    public GameObject Text;
    public GameObject comment1;
    public GameObject comment2;
    public int score;
    public Animator trans;

    void Start()
    {
        score = ScoreCounter.score;
        Text.GetComponent<Text>().text = "You helped " + ScoreCounter.score + " ghost";

        if (score < 5)
        {
            comment1.GetComponent<Text>().text = "You can do better!";
            comment2.GetComponent<Text>().text = "I don't wanna talk to you";
        }
        if (score > 5 && score < 10)
        {
            comment1.GetComponent<Text>().text = "Thank you!";
            comment2.GetComponent<Text>().text = "I can do 10 times better";
        }

        if (score > 10 && score < 20)
        {
            comment1.GetComponent<Text>().text = "Wow you are good at this";
            comment2.GetComponent<Text>().text = "Not too bad";
        }

        if (score > 20)
        {
            comment1.GetComponent<Text>().text = "You are a natural!";
            comment2.GetComponent<Text>().text = "We choose the right person";
        }
    }


    public void restart()
    {
        ScoreCounter.score = 0;
        StartCoroutine(LoadScene());

    }


    private IEnumerator LoadScene()
    {
        trans.SetTrigger("tran");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game");
    }
}
