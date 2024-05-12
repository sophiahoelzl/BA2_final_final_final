using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{

    public GameObject chair_canvas;

    public void ShowSpanishChairText()
    {
        chair_canvas.SetActive(!chair_canvas.activeSelf);
    }

    public void CloseSpanishChairText()
    {
        chair_canvas.SetActive(!chair_canvas.activeSelf);
    }
}
