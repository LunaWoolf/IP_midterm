using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public Material paint;
    public Material unpaint;
    public bool ispaint = false;
    void Start()
    {
        
    }

 
    void Update()
    {
        if (ispaint)
            this.GetComponent<MeshRenderer>().material = paint;
        if (!ispaint)
            this.GetComponent<MeshRenderer>().material = unpaint;

    }
}
