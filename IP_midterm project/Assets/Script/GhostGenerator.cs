using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGenerator : MonoBehaviour
{
    public GameObject Ghost;
    public GameObject[] points;
    public GameObject Player;

    void Start()
    {
        StartCoroutine(Generate());
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            GameObject temp = Instantiate(Ghost, this.transform.position, Quaternion.identity);
            //temp.GetComponent<Ghost>().points = this.points;
            temp.GetComponent<Ghost>().Player = this.Player;
            yield return new WaitForSeconds(10f);
            
        }
    }

    


}
