using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject door_canvas;

    public void ShowSpanishDoorText()
    {
        door_canvas.SetActive(!door_canvas.activeSelf);
    }

    public void CloseSpanishDoorText()
    {
        door_canvas.SetActive(!door_canvas.activeSelf);
    }
}
