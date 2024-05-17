using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{

    public GameObject pen_canvas;

    public void ShowSpanishPenText()
    {
        pen_canvas.SetActive(!pen_canvas.activeSelf);
    }

    public void CloseSpanishPenText()
    {
        pen_canvas.SetActive(!pen_canvas.activeSelf);
    }
}
