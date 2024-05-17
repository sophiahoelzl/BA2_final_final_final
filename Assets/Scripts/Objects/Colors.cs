using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{

    public GameObject blue_canvas;
    public GameObject green_canvas;
    public GameObject red_canvas;
    public GameObject yellow_canvas;
    public GameObject purple_canvas;
    public GameObject orange_canvas;
    public GameObject white_canvas;

    public void ShowBlue()
    {
        blue_canvas.SetActive(!blue_canvas.activeSelf);
    }

    public void CloseBlue()
    {
        blue_canvas.SetActive(!blue_canvas.activeSelf);
    }

    public void ShowRed()
    {
        red_canvas.SetActive(!red_canvas.activeSelf);
    }

    public void CloseRed()
    {
        red_canvas.SetActive(!red_canvas.activeSelf);
    }

    public void ShowYellow()
    {
        yellow_canvas.SetActive(!yellow_canvas.activeSelf);
    }

    public void CloseYellow()
    {
        yellow_canvas.SetActive(!yellow_canvas.activeSelf);
    }

    public void ShowGreen()
    {
        green_canvas.SetActive(!green_canvas.activeSelf);
    }

    public void CloseGreen()
    {
        green_canvas.SetActive(!green_canvas.activeSelf);
    }

    public void ShowPurple()
    {
        purple_canvas.SetActive(!purple_canvas.activeSelf);
    }

    public void ClosePurple()
    {
        purple_canvas.SetActive(!purple_canvas.activeSelf);
    }

    public void ShowOrange()
    {
        orange_canvas.SetActive(!orange_canvas.activeSelf);
    }

    public void CloseOrange()
    {
        orange_canvas.SetActive(!orange_canvas.activeSelf);
    }

    public void ShowWhite()
    {
        white_canvas.SetActive(!white_canvas.activeSelf);
    }

    public void CloseWhite()
    {
        white_canvas.SetActive(!white_canvas.activeSelf);
    }

}
