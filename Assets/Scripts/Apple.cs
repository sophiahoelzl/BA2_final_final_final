using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public GameObject apple_canvas;

    public void ShowSpanishAppleText()
    {
        apple_canvas.SetActive(!apple_canvas.activeSelf);
    }

    public void CloseSpanishAppleText()
    {
        apple_canvas.SetActive(!apple_canvas.activeSelf);
    }
}
