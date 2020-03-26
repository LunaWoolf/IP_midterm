using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class Dialogue: ScriptableObject
{
    public new string name;
    public bool hasquestion;
    public Question question;



    [TextArea(3, 10)]
    public string[] sentence;

    public GameObject nextdialogue;

}
