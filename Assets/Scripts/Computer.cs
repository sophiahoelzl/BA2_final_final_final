using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{

    public GameObject computer_canvas;

    public void ShowSpanishComputerText()
    {
        computer_canvas.SetActive(!computer_canvas.activeSelf);
    }

    public void CloseSpanishComputerText()
    {
        computer_canvas.SetActive(!computer_canvas.activeSelf);
    }
}
