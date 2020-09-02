using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    private Vector3 currentPos,StartPos;
    private float UpMax, DownMax, LeftMax, RightMax,MUp,MDown,MLeft,MRight;
    public Text DialogBox;
    private void Awake()
    {
        StartPos = transform.position; currentPos = StartPos;//sets starting pos.
        UpMax = 5f; DownMax = -1f; LeftMax = -6f; RightMax = 6f;
        MUp = 1f; MDown = -1f; MLeft = -1f; MRight = 1f;
        DialogBox.GetComponent<TypeController>().FullText = "Welcome! Click a button to move!";
    }
    private void Update()
    {
        transform.position = currentPos;
        if(transform.position.x > RightMax)
        {
            currentPos.x = RightMax;
            DialogBox.GetComponent<TypeController>().FullText = "The Player cannot go this way.";
        }
        if(transform.position.x < LeftMax)
        {
            currentPos.x = LeftMax;
            DialogBox.GetComponent<TypeController>().FullText = "The Player cannot go this way.";
        }
        if(transform.position.y > UpMax)
        {
            currentPos.y = UpMax;
            DialogBox.GetComponent<TypeController>().FullText = "The Player cannot go this way.";
        }
        if(transform.position.y < DownMax)
        {
            currentPos.y = DownMax;
            DialogBox.GetComponent<TypeController>().FullText = "The Player cannot go this way.";
        }
    }
    public void MoveUp()
    {
        currentPos += new Vector3(0f, MUp, 0f);
        DialogBox.GetComponent<TypeController>().FullText = "The Player moved up.";
    }
    public void MoveDown()
    {
        currentPos += new Vector3(0f, MDown, 0);
        DialogBox.GetComponent<TypeController>().FullText = "The Player moved down.";
    }
    public void MoveRight()
    {
        currentPos += new Vector3(MRight, 0f, 0f);
        DialogBox.GetComponent<TypeController>().FullText = "The Player moved right.";
    }
    public void MoveLeft()
    {
        currentPos += new Vector3(MLeft, 0f, 0f);
        DialogBox.GetComponent<TypeController>().FullText = "The Player moved left.";
    }
}
