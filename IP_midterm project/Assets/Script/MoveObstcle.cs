using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class contorl the movement of nav mesh obstrcle
public class MoveObstcle : MonoBehaviour
{
    public float minlimit;
    public float maxlimit;
    public int dir = 1;
    public float movespeed;

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
