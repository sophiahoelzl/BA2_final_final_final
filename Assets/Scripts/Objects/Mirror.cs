using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{

    public GameObject mirror_canvas;

    public void ShowSpanishMirrorText()
    {
        mirror_canvas.SetActive(!mirror_canvas.activeSelf);
    }

    public void CloseSpanishMirrorText()
    {
        mirror_canvas.SetActive(!mirror_canvas.activeSelf);
    }
}
