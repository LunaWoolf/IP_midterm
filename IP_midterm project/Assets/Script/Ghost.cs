using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour
{
    public int pattern;
    public NavMeshAgent na;
    public GameObject[] points;
    public int cur;
    public Vector3 target;
    public GameObject Player;
    //public float speed;

    void Start()
    {
        pattern = Random.Range(1, 6);
       
    }

  
    void Update()
    {
        
        if (na.hasPath == false && na.velocity == Vector3.zero)
        {
            //na.speed = speed;
            //cur = Random.Range(0, points.Length);
            na.SetDestination(Player.transform.position);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Endstage");
            Destroy(col.gameObject);
          
        }
    }
}
