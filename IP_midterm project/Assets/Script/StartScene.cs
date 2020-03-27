using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    public Animator trans;

    void Start()
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
        trans.SetTrigger("trans");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("DialogueScene");
    }
}
