using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{

    public GameObject book_canvas;

    public void ShowSpanishBookText()
    {
        book_canvas.SetActive(!book_canvas.activeSelf);
    }

    public void CloseSpanishBookText()
    {
        book_canvas.SetActive(!book_canvas.activeSelf);
    }
}
