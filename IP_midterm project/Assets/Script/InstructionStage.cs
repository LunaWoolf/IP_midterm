using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This switch the instruction scene to the game stage
public class InstructionStage : MonoBehaviour
{
    public Animator trans;

    public void nextScene()
    {

        StartCoroutine(LoadScene());

    }

    private IEnumerator LoadScene()
    {
        trans.SetTrigger("tran");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game");
    }
}
