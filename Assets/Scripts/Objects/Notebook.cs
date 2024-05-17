using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{

    public GameObject notebook_canvas;

    public void ShowSpanishNotebookText()
    {
        notebook_canvas.SetActive(!notebook_canvas.activeSelf);
    }

    public void CloseSpanishNotebookText()
    {
        notebook_canvas.SetActive(!notebook_canvas.activeSelf);
    }
}
