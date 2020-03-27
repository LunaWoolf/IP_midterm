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
    public bool characterimage01;
    public bool characterimage02;



    [TextArea(3, 10)]
    public string[] sentence;

    public Dialogue nextdialogue;

}
