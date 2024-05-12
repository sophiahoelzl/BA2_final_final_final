using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{

    public GameObject cup_canvas;

    public void ShowSpanishCupText()
    {
        cup_canvas.SetActive(!cup_canvas.activeSelf);
    }

    public void CloseSpanishCupText()
    {
        cup_canvas.SetActive(!cup_canvas.activeSelf);
    }
}
