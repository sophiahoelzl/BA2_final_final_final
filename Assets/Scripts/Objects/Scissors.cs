using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : MonoBehaviour
{

    public GameObject scissors_canvas;

    public void ShowSpanishScissorsText()
    {
        scissors_canvas.SetActive(!scissors_canvas.activeSelf);
    }

    public void CloseSpanishScissorsText()
    {
        scissors_canvas.SetActive(!scissors_canvas.activeSelf);
    }
}
