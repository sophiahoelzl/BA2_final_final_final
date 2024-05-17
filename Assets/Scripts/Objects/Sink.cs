using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour
{

    public GameObject sink_canvas;

    public void ShowSpanishSinkText()
    {
        sink_canvas.SetActive(!sink_canvas.activeSelf);
    }

    public void CloseSpanishSinkText()
    {
        sink_canvas.SetActive(!sink_canvas.activeSelf);
    }
}
