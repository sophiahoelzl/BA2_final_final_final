using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{

    public GameObject backpack_canvas;

    public void ShowSpanishBackpackText()
    {
        backpack_canvas.SetActive(!backpack_canvas.activeSelf);
    }

    public void CloseSpanishBackpackText()
    {
        backpack_canvas.SetActive(!backpack_canvas.activeSelf);
    }
}
