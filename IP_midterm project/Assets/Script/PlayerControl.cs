using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float rayLength;
    public LayerMask layermask;
    public Material material;
    public bool hasFu;
    public GameObject Fu;
    public GameObject curGhost = null;
    public GameObject curPattern;
    public GameObject pattern1;
    public GameObject pattern2;
    public GameObject pattern3;
    public GameObject pattern4;
    public GameObject pattern5;

    public GameObject scoreText;
    public int score = 0;



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
                    if (curGhost != null && curGhost != hit.collider.gameObject)
                    {
                        curGhost.GetComponentInChildren<SpriteRenderer>().color = new Color(0, 0, 0, 1);
                        clearpaint();
                    }

                    curGhost = hit.collider.gameObject;
                    curGhost.GetComponentInChildren<SpriteRenderer>().color = new Color(1, 1, 1, 1);
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
                        case 3:
                            pattern3.SetActive(true);
                            curPattern = pattern3;
                            break;
                        case 4:
                            pattern4.SetActive(true);
                            curPattern = pattern4;
                            break;
                        case 5:
                            pattern5.SetActive(true);
                            curPattern = pattern5;
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

        scoreText.GetComponent<Text>().text = ""+ score;


    }

    void finishPaint()
    {
        Destroy(curGhost);
        score += 1;
        ScoreCounter.score = score;
        foreach (Paint p in curPattern.GetComponent<pattern>().paintlist)
        {
            p.ispaint = false;
        }
        curPattern.SetActive(false);


    }

    void clearpaint()
    {
        
        foreach (Paint p in curPattern.GetComponent<pattern>().paintlist)
        {
            p.ispaint = false;
        }
        curPattern.SetActive(false);
    }
}
