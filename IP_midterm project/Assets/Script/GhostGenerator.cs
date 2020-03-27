using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGenerator : MonoBehaviour
{
    public GameObject Ghost;
    public GameObject[] points;
    public GameObject Player;
    public Animator trans;
    public float waittime = 10f;


    void Start()
    {
        StartCoroutine(Generate());
        StartCoroutine(decreasewaittime());
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            GameObject temp = Instantiate(Ghost, this.transform.position, Quaternion.identity);
            temp.GetComponent<Ghost>().points = this.points;
            temp.GetComponent<Ghost>().trans = this.trans;
            temp.GetComponent<Ghost>().Player = this.Player;
            yield return new WaitForSeconds(waittime);
            
        }
    }

    private IEnumerator decreasewaittime()
    {
        while (waittime > 5)
        {
            waittime -= 0.5f;
            yield return new WaitForSeconds(10f);

        }
    }




}
