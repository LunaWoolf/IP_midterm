using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class check individual dots of paint
public class Paint : MonoBehaviour
{
    public Material paint;
    public Material unpaint;
    public bool ispaint = false;

    void Update()
    {
        if (ispaint)
            this.GetComponent<MeshRenderer>().material = paint;
        if (!ispaint)
            this.GetComponent<MeshRenderer>().material = unpaint;

    }
}
