using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{

    public GameObject painting_canvas;

    public void ShowSpanishPaintingText()
    {
        painting_canvas.SetActive(!painting_canvas.activeSelf);
    }

    public void CloseSpanishPaintingText()
    {
        painting_canvas.SetActive(!painting_canvas.activeSelf);
    }
}
