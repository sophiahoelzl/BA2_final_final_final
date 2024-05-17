using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{

    public GameObject calculator_canvas;

    public void ShowSpanishCalculatorText()
    {
        calculator_canvas.SetActive(!calculator_canvas.activeSelf);
    }

    public void CloseSpanishCalculatorText()
    {
        calculator_canvas.SetActive(!calculator_canvas.activeSelf);
    }
}
