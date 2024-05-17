using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banane : MonoBehaviour
{

    public GameObject banane_canvas;

    public void ShowSpanishBananeText()
    {
        banane_canvas.SetActive(!banane_canvas.activeSelf);
    }

    public void CloseSpanishBananeText()
    {
        banane_canvas.SetActive(!banane_canvas.activeSelf);
    }
}
