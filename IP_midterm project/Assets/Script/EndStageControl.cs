using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndStageControl : MonoBehaviour
{
    public GameObject Text;
    public int score;
  
    void Start()
    {
        score = ScoreCounter.score;
        Text.GetComponent<Text>().text = "You helped " + ScoreCounter.score + " ghost";

    }


    public void restart()
    {
        
       SceneManager.LoadScene("Game");
         
        
    }
}
