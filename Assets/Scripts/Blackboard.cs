using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Blackboard : MonoBehaviour
{
    public Text Question;
    public GameObject Cheatsheet;
    public GameObject AnswerCanvas;
    public TMP_Text inputText;

    public GameObject canvasHelp;
    public Text helpText;

    public int attempt = 0;
    public int question = 0;

    private string answer_1 = "sietemanzanas";
    private string answer_2 = "seisbotellas";
    private string answer_3 = "ochoportátiles";
    private string answer_4 = "cincomochilas";
    private string answer_5 = "lasnuevedelamañana";

    private static string question_1 = "How many apples are in this classroom?";
    private static string question_2 = "How many bottles are in this classroom?";
    private static string question_3 = "How many laptops are in this classroom?";
    private static string question_4 = "How many backpacks are in this classroom?";
    private static string question_5 = "What time is it?";
    string[] questionArray = new string[]{question_1, question_2, question_3, question_4, question_5};


    public void checkAnswer()
    {
        string textAnswer = new string(inputText.text.Where(c => char.IsLetter(c) || char.IsDigit(c)).ToArray());
        attempt += 1;
        openHelpCanvas(attempt.ToString());

        switch(question) 
        {
        case 1:
            questionApple(textAnswer, attempt);
            break;
        case 2:
            questionBottle(textAnswer, attempt);
            break;
        case 3:
            questionLaptop(textAnswer, attempt);
            break;
        case 4:
            questionBackpack(textAnswer, attempt);
            break;
        case 5:
            questionTime(textAnswer, attempt);
            break;
        }
    }

    public void openHelpCanvas(string text)
    {
        canvasHelp.SetActive(true);
        helpText.text = text;
    }

    public void closeHelpCanvas()
    {
        canvasHelp.SetActive(false);
    }


    public void questionApple(string textAnswer, int attempt)
    {
        if (answer_1 == textAnswer)
        {
            openHelpCanvas("correct!");
            question += 1;
            nextQuestion();
            StartCoroutine(HideAndShow(4.0f));
        }
        else if (answer_1 != textAnswer && attempt >= 2)
        {
            canvasHelp.SetActive(true);
            helpText.text = "If you want to specify several objects, you need an 's' at the end in Spanish";
        }
        else if (answer_1 != textAnswer && attempt >= 4)
        {
            canvasHelp.SetActive(true);
            helpText.text = "una manzana, dos manzanas, ...";
        }
    }

    public void questionBottle(string textAnswer, int attempt)
    {
        if (answer_2 == textAnswer)
        {
            openHelpCanvas("Well done!");
            question += 1;
            nextQuestion();
            StartCoroutine(HideAndShow(4.0f));
        }
        else if (answer_2 != textAnswer && attempt >= 2)
        {
            canvasHelp.SetActive(true);
            helpText.text = "If you want to specify several objects, you need an 's' at the end in Spanish";
        }
        else if (answer_2 != textAnswer && attempt >= 4)
        {
            canvasHelp.SetActive(true);
            helpText.text = "una manzana, dos manzanas, ...";
        }

    }

    public void questionLaptop(string textAnswer, int attempt)
    {
        if (answer_3 == textAnswer)
        {
            openHelpCanvas("Bueno!");
            question += 1;
            nextQuestion();
            StartCoroutine(HideAndShow(4.0f));
        }
        else if (answer_3 != textAnswer && attempt >= 2)
        {
            canvasHelp.SetActive(true);
            helpText.text = "If you want to specify several objects, you need an 's' at the end in Spanish";
        }
        else if (answer_3 != textAnswer && attempt >= 4)
        {
            canvasHelp.SetActive(true);
            helpText.text = "una manzana, dos manzanas, ...";
        }

    }

    public void questionBackpack(string textAnswer, int attempt)
    {
        if (answer_4 == textAnswer)
        {
            openHelpCanvas("profesional español!");
            question += 1;
            nextQuestion();
            StartCoroutine(HideAndShow(4.0f));
        }
        else if (answer_4 != textAnswer && attempt >= 2)
        {
            canvasHelp.SetActive(true);
            helpText.text = "If you want to specify several objects, you need an 's' at the end in Spanish";
        }
        else if (answer_4 != textAnswer && attempt >= 4)
        {
            canvasHelp.SetActive(true);
            helpText.text = "una manzana, dos manzanas, ...";
        }

    }

    public void questionTime(string textAnswer, int attempt)
    {

        if (answer_5 == textAnswer)
        {
            openHelpCanvas("correct!");
            question += 1;
            nextQuestion();
            StartCoroutine(HideAndShow(4.0f));
        }
        else if (answer_5 != textAnswer && attempt >= 2)
        {
            canvasHelp.SetActive(true);
            helpText.text = "I know this is hard! Maybe this will help";
            Cheatsheet.SetActive(true);
        }
        else if (answer_5 != textAnswer && attempt >= 4)
        {
            canvasHelp.SetActive(true);
            helpText.text = "Like with the multiple objects you need to put an s!";
            Cheatsheet.SetActive(true);
        }
        else if (answer_5 != textAnswer && attempt >= 5)
        {
            canvasHelp.SetActive(true);
            helpText.text = "las diez de la mañana -> ten o'clock in the morning";
            Cheatsheet.SetActive(true);
        }
    }


    public void nextQuestion()
    {
        changeText();
        inputText.text = "hallo";
    }

    public void changeText()
    {
        if (question == 6)
        {
            finishGame();
        }
        else
        {
            Question.text = questionArray[question];
        }
    }

    public void finishGame()
    {
        Question.text = "You did it! Thank you for playing";
        AnswerCanvas.SetActive(false);
        Cheatsheet.SetActive(false);
    }

    IEnumerator HideAndShow(float delay)
    {
        yield return new WaitForSeconds(delay);
        canvasHelp.SetActive(false);
    }
}
