using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soap : MonoBehaviour
{

    public GameObject soap_canvas;

    public void ShowSpanishSoapText()
    {
        soap_canvas.SetActive(!soap_canvas.activeSelf);
    }

    public void CloseSpanishSoapText()
    {
        soap_canvas.SetActive(!soap_canvas.activeSelf);
    }
}
