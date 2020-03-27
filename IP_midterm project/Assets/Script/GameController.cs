using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    GameObject DialogueTrigger;
    void Start()
    {
        DialogueTrigger = GameObject.Find("DialogueTrigger");
        DialogueTrigger.GetComponent<DialogueTrigger>().TriggerDialogue();
    }

    void Update()
    {
        
    }
}
