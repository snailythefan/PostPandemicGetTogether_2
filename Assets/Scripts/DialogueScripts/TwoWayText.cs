using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Dialogue //This is a struct. Please do not be afraid
{
    public string name;
    public GameObject speechBubble;
    								//delete this if it doesn't work
    								public GameObject characterPortrait;

    [TextArea(3, 5)]
    public string words;

    

}
public class TwoWayText : MonoBehaviour
{
    //An array of structs
    public Dialogue[] dialogue;

    							//delete this if it doesn't work
    							//public Portraits[] pics;
}