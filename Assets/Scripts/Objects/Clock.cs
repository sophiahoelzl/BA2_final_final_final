using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    public GameObject clock_canvas;

    public void ShowSpanishClockText()
    {
        clock_canvas.SetActive(!clock_canvas.activeSelf);
    }

    public void CloseSpanishClockText()
    {
        clock_canvas.SetActive(!clock_canvas.activeSelf);
    }
}
