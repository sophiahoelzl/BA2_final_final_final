using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laptop : MonoBehaviour
{

    public GameObject laptop_canvas;

    public void ShowSpanishLaptopText()
    {
        laptop_canvas.SetActive(!laptop_canvas.activeSelf);
    }

    public void CloseSpanishLaptopText()
    {
        laptop_canvas.SetActive(!laptop_canvas.activeSelf);
    }
}
