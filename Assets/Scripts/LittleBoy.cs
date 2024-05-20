using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class LittleBoy : MonoBehaviour
{

    public GameObject LittleBoyCanvas;
    public GameObject AnswerCanvas;
    public TextMeshProUGUI AnswerCanvastext;
    public TextMeshProUGUI LittleBoyText;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;

    public Button p1_1;
    public Button p1_2;
    public Button p1_3;
    public Button p2_1;
    public Button p2_2;
    public Button p2_3;
    public Button p3_1;
    public Button p3_2;
    public Button p3_3;
    public Button p4_1;
    public Button p4_2;
    public Button p4_3;
    public Button p5_1;
    public Button p5_2;
    public Button p5_3;

    private static string question_1 = "Hola Me llamo Mateo!";
    private static string question_2 = "¿Cómo estás?";
    private static string question_3 = "¿Qué tal el día?";
    private static string question_4 = "¿Te gusta la comida española?";
    private static string question_5 = "¿Has estado alguna vez en España?";
    string[] questionArray = new string[]{question_1, question_2, question_3, question_4, question_5};
    private int question = 0;

    private static string subtitel_1 = "Hello, my name is Mateo!";
    private static string subtitel_2 = "How are you doing?";
    private static string subtitel_3 = "How was your day?";
    private static string subtitel_4 = "Do you like Spanish food?";
    private static string subtitel_5 = "Have you ever been to Spain?";
    string[] subtitelArray = new string[]{subtitel_1, subtitel_2, subtitel_3, subtitel_4, subtitel_5};

    public void startConvo()
    {
        LittleBoyCanvas.SetActive(true);
        AnswerCanvas.SetActive(true);
        showQuestion();
    }

    public void checkAnswer(int button)
    {
        if(question == 0)
        {
            if(button == 1){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 2){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 3){
                AnswerCanvastext.text = "correct answer!";
                StartCoroutine(nextQuestion(3.0f));
                p1_1.enabled = false;
                p1_2.enabled = false;
                p1_3.enabled = false;
            }

        }
        else if (question == 1)
        {
            if(button == 1){
                AnswerCanvastext.text = "correct answer!";
                StartCoroutine(nextQuestion(3.0f));
                p2_1.enabled = false;
                p2_2.enabled = false;
                p2_3.enabled = false;
            }
            else if(button == 2){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 3){
                AnswerCanvastext.text = "try again!";
            }

        }
        else if (question == 2)
        {
            if(button == 1){
                AnswerCanvastext.text = "correct answer!";
                StartCoroutine(nextQuestion(3.0f));
                p3_1.enabled = false;
                p3_2.enabled = false;
                p3_3.enabled = false;
            }
            else if(button == 2){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 3){
                AnswerCanvastext.text = "try again!";
            }

        }
        else if (question == 3)
        {
            if(button == 1){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 2){
                AnswerCanvastext.text = "correct answer!";
                StartCoroutine(nextQuestion(3.0f));
                p4_1.enabled = false;
                p4_2.enabled = false;
                p4_3.enabled = false;
            }
            else if(button == 3){
                AnswerCanvastext.text = "try again!";
            }

        }
        else if (question == 4)
        {
            if(button == 1){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 2){
                AnswerCanvastext.text = "try again!";
            }
            else if(button == 3){
                AnswerCanvastext.text = "correct answer!";
                StartCoroutine(nextQuestion(3.0f));
                StartCoroutine(showBye(3.0f));
                LittleBoyText.text = "¡Adiós! Hasta luego.";
                p5_1.enabled = false;
                p5_2.enabled = false;
                p5_3.enabled = false;
            }

        }
    }

    public void showQuestion()
    {
        LittleBoyText.text = questionArray[question];
        AnswerCanvastext.text = "choose your answer...";

       switch(question) 
            {
            case 0:
                TogglefirstQuestion(true);
                break;
            case 1:
                TogglesecondQuestion(true);
                break;
            case 2:
                TogglethirdQuestion(true);
                break;
            case 3:
                TogglefourthQuestion(true);
                break;
            case 4:
                TogglefifthQuestion(true);
                break;
            }
    }

    public void TogglefirstQuestion(bool show)
    {
        p1.SetActive(show);
    }

    public void TogglesecondQuestion(bool show)
    {
        p2.SetActive(show);
    }

    public void TogglethirdQuestion(bool show)
    {
        p3.SetActive(show);
    }

    public void TogglefourthQuestion(bool show)
    {
        p4.SetActive(show);
    }

    public void TogglefifthQuestion(bool show)
    {
        p5.SetActive(show);
    }

    IEnumerator showBye(float delay)
    {
        yield return new WaitForSeconds(delay);
        LittleBoyCanvas.SetActive(false);
        AnswerCanvas.SetActive(false);
    }

    IEnumerator nextQuestion(float delay)
    {
        yield return new WaitForSeconds(delay);

        switch(question) 
            {
            case 0:
                TogglefirstQuestion(false);
                break;
            case 1:
                TogglesecondQuestion(false);
                break;
            case 2:
                TogglethirdQuestion(false);
                break;
            case 3:
                TogglefourthQuestion(false);
                break;
            case 4:
                TogglefifthQuestion(false);
                break;
            }

        question += 1;
        showQuestion();
    }

}
