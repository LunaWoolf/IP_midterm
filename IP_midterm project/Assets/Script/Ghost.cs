using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ghost : MonoBehaviour
{
    public int pattern;
    public NavMeshAgent na;
    public GameObject[] points;
    public int cur;
    public Vector3 target;
    //public float speed;

    void Start()
    {
        pattern = Random.Range(1, 3);        
    }

  
    void Update()
    {
        if (na.hasPath == false && na.velocity == Vector3.zero)
        {
            cur = Random.Range(0, points.Length);
            //na.speed = speed;
            na.SetDestination(points[cur].transform.position);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
