using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script check is the paint finish and send message when it's
public class pattern : MonoBehaviour
{
    public Material paint;
    public List<Paint> paintlist;
    public GameObject PlayerControl;
    public bool finish = true;

    void Start()
    {
        foreach (Transform child in this.transform)
        {
            paintlist.Add(child.GetComponent<Paint>());
        }
    }


    public void checkpaint()
    {
        Debug.Log("finish");
        finish = true;
        foreach (Paint p in paintlist)
        {
            if (!p.ispaint)
            {
                finish = false;
            }
        }

        if(finish)
            PlayerControl.GetComponent<PlayerControl>().SendMessage("finishPaint");
    }
}
