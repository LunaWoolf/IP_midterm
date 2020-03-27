using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGenerator : MonoBehaviour
{
    public GameObject Ghost;
    public GameObject[] points;

    void Start()
    {
        StartCoroutine(Generate());
    }

   
    void Update()
    {
        
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            GameObject temp = Instantiate(Ghost, this.transform.position, Quaternion.identity);
            temp.GetComponent<Ghost>().points = this.points;
            yield return new WaitForSeconds(10f);
            
        }
    }


}
