using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eraser : MonoBehaviour
{

    public GameObject eraser_canvas;

    public void ShowSpanishEraserText()
    {
        eraser_canvas.SetActive(!eraser_canvas.activeSelf);
    }

    public void CloseSpanishEraserText()
    {
        eraser_canvas.SetActive(!eraser_canvas.activeSelf);
    }
}
