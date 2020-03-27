using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }


        /*if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.localRotation = Quaternion.Euler(0, 90, 0);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.localRotation = Quaternion.Euler(0, -90, 0);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.localRotation = Quaternion.Euler(0, 180, 0);

        }*/
    }
}
