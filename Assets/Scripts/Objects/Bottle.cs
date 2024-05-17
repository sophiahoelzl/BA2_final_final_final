using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{

    public GameObject bottle_canvas;

    public void ShowSpanishBottleText()
    {
        bottle_canvas.SetActive(!bottle_canvas.activeSelf);
    }

    public void CloseSpanishBottleText()
    {
        bottle_canvas.SetActive(!bottle_canvas.activeSelf);
    }
}
