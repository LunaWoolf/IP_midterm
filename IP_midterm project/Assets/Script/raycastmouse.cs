using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class raycastmouse : MonoBehaviour
{
    public float rayLength;
    public LayerMask layermask;
    public Material material;
    public bool hasFu;
    public GameObject Fu;
    public GameObject curGhost;
    public GameObject curPattern;
    public GameObject pattern1;
    public GameObject pattern2;


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layermask))
            {
                if (hit.collider.gameObject.tag == "Ghost")
                {
                    curGhost = hit.collider.gameObject;
                    if (!hasFu)
                        Fu.SetActive(true);

                    int patternnum = hit.collider.gameObject.GetComponent<Ghost>().pattern;

                    switch (patternnum)
                    {
                        case 1:
                            pattern1.SetActive(true);
                            curPattern = pattern1;
                            break;
                        case 2:
                            pattern2.SetActive(true);
                            curPattern = pattern2;
                            break;
                    }
                }

                if (hit.collider.gameObject.tag == "Paint")
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material = curPattern.GetComponent<pattern>().paint;
                    hit.collider.gameObject.GetComponent<Paint>().ispaint = true;
                    curPattern.GetComponent<pattern>().checkpaint();
                }
                    
            }     
        }

        
        
    }

    void finishPaint()
    {
        Destroy(curGhost);
        foreach (Paint p in curPattern.GetComponent<pattern>().paintlist)
        {
            p.ispaint = false;
        }
        curPattern.SetActive(false);
        
       
    }
}
