﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionStage : MonoBehaviour
{
    
    void Start()
    {
     
    }


    public void restart()
    {
        
        SceneManager.LoadScene("Game");

    }
}
