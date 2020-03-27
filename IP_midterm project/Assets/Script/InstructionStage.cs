using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionStage : MonoBehaviour
{
    public Animator trans;

    void Start()
    {
     
    }


    public void nextScene()
    {

        StartCoroutine(Wait());

    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(6f);
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        trans.SetTrigger("tran");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game");
    }
}
