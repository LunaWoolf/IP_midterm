using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstcle : MonoBehaviour
{
    public float minlimit;
    public float maxlimit =0.5f;
    public int dir = 1;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        if (this.transform.position.x < minlimit)
        {
            dir = 1;
        }


        if (this.transform.position.x > maxlimit)
        {
            dir = -1;
        }

        transform.position += new Vector3(movespeed * Time.deltaTime * dir, 0, 0);
    }
}
