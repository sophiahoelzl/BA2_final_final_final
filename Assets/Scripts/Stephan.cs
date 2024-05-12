using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Stephan : MonoBehaviour
{

    public GameObject canvas;
    public GameObject cube_1;
    public GameObject cube_2;
    public Text button_text;
    public Text text;

 
    public void showText()
    {
        canvas.SetActive(true);
        cube_1.SetActive(true);

    }

    public void closeText()
    {
        canvas.SetActive(false);
        cube_2.SetActive(false);

    }

    public void changeText()
    {
        text.text = "Look around, interact and explore with objects in this classroom in spanish!                       For further instructions look at the blackboard";
        button_text.text = "Got it!";
        StartCoroutine(HideAndShow(2.0f) );
        cube_1.SetActive(false);
    }

    IEnumerator HideAndShow(float delay)
    {
        yield return new WaitForSeconds(delay);
        cube_2.SetActive(true);
    }
}
