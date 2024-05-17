using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintbrush : MonoBehaviour
{

    public GameObject paintbrush_canvas;

    public void ShowSpanishPaintbrushText()
    {
        paintbrush_canvas.SetActive(!paintbrush_canvas.activeSelf);
    }

    public void CloseSpanishPaintbrushText()
    {
        paintbrush_canvas.SetActive(!paintbrush_canvas.activeSelf);
    }
}
