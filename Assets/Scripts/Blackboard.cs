using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Blackboard : MonoBehaviour
{
    public GameObject QuestionCanvas;
    public GameObject NextLecture;
    public Text QuestionText;
    public GameObject CheatsheetCanvas;
    public GameObject CheatsheetCanvasTime;
    public GameObject AnswerCanvas;
    public Button Checkbutton;
    public GameObject Keyboard;
    public TMP_Text inputText;
    public TMP_InputField inputField;
    private TMP_Text placeholderText;

    public GameObject canvasHelp;
    public Text helpText;

    private int attempt = 0;
    private int question = 0;

    ColorGamelogic colorGamelogic = new ColorGamelogic();

    /*private string answer_1 = "sietemanzanas";
    private string answer_2 = "seisbotellas";
    private string answer_3 = "ochoportátiles";
    private string answer_4 = "cincomochilas";
    private string answer_5 = "lasnuevedelamañana";*/

    private string answer_1 = "a";
    private string answer_2 = "a";
    private string answer_3 = "a";
    private string answer_4 = "a";
    private string answer_5 = "a";

    private static string question_1 = "How many apples are in this classroom?";
    private static string question_2 = "How many bottles are in this classroom?";
    private static string question_3 = "How many laptops are in this classroom?";
    private static string question_4 = "How many backpacks are in this classroom?";
    private static string question_5 = "What time is it?";
    string[] questionArray = new string[]{question_1, question_2, question_3, question_4, question_5};

    public void Start()
    {
        placeholderText = inputField.placeholder.GetComponent<TMP_Text>();
    }

    public void setBlackboard()
    {
        QuestionCanvas.SetActive(true);
        QuestionText.text = questionArray[question];
        AnswerCanvas.SetActive(true);
        Checkbutton.enabled = true;
        Keyboard.SetActive(false);
        CheatsheetCanvas.SetActive(true);
        placeholderText.text = "Type here..";
        inputField.text = "";
        attempt = 0;
    }

    public void checkAnswer()
    {
        string textAnswer = new string(inputText.text.Where(c => char.IsLetter(c) || char.IsDigit(c)).ToArray());
        attempt += 1;
        switch(question) 
        {
        case 0:
            questionApple(textAnswer, attempt);
            break;
        case 1:
            questionBottle(textAnswer, attempt);
            break;
        case 2:
            questionLaptop(textAnswer, attempt);
            break;
        case 3:
            questionBackpack(textAnswer, attempt);
            break;
        case 4:
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
            openHelpCanvas("Correct!");
            question += 1;
            Checkbutton.enabled = false;
            StartCoroutine(Pause(3.0f));
        }
        else if (answer_1 != textAnswer && attempt >= 1 && attempt < 2)
        {
            openHelpCanvas("Something is wrong! Try it again.");
        }
        else if (answer_1 != textAnswer && attempt >= 2 && attempt < 4)
        {
            openHelpCanvas("To specify objects in the plural you need an 's' at the end");
        }
        else if (answer_1 != textAnswer && attempt >= 4 && attempt < 7)
        {
            openHelpCanvas("una manzana, dos manzanas, ...");
        }
        else if (answer_1 != textAnswer && attempt >= 8)
        {
            placeholderText.text = "siete ...";
            openHelpCanvas("una manzana, dos manzanas, ...");
        }
    }

    public void questionBottle(string textAnswer, int attempt)
    {
        if (answer_2 == textAnswer)
        {
            openHelpCanvas("Well done!");
            question += 1;
            Checkbutton.enabled = false;
            StartCoroutine(Pause(3.0f));
        }
        else if (answer_1 != textAnswer && attempt >= 1 && attempt < 2)
        {
            openHelpCanvas("Something is wrong! Try it again.");
        }
        else if (answer_2 != textAnswer && attempt >= 2 && attempt < 4)
        {
            openHelpCanvas("To specify objects in the plural you need an 's' at the end");
        }
        else if (answer_2 != textAnswer && attempt >= 4 && attempt < 7)
        {
            openHelpCanvas("una botella, dos botellas, ...");
        }
        else if (answer_1 != textAnswer && attempt >= 8)
        {
            placeholderText.text = "seise ...";
            openHelpCanvas("una botella, dos botellas, ...");
        }

    }

    public void questionLaptop(string textAnswer, int attempt)
    {
        if (answer_3 == textAnswer)
        {
            openHelpCanvas("Bueno!");
            question += 1;
            Checkbutton.enabled = false;
            StartCoroutine(Pause(3.0f));
        }
        else if (answer_1 != textAnswer && attempt >= 1 && attempt < 2)
        {
            openHelpCanvas("Something is wrong! Try it again.");
        }
        else if (answer_3 != textAnswer && attempt >= 2 && attempt < 4)
        {
            openHelpCanvas("To specify objects in the plural you need an 's' at the end");
        }
        else if (answer_3 != textAnswer && attempt >= 4 && attempt < 7)
        {
            openHelpCanvas("una portátil, dos portátiles, ...");
        }
        else if (answer_1 != textAnswer && attempt >= 8)
        {
            placeholderText.text = "ocho ...";
            openHelpCanvas("una portátil, dos portátiles, ...");
        }

    }

    public void questionBackpack(string textAnswer, int attempt)
    {
        if (answer_4 == textAnswer)
        {
            openHelpCanvas("profesional español!");
            question += 1;
            Checkbutton.enabled = false;
            StartCoroutine(Pause(3.0f));
        }
        else if (answer_1 != textAnswer && attempt >= 1 && attempt < 2)
        {
            openHelpCanvas("Something is wrong! Try it again.");
        }
        else if (answer_4 != textAnswer && attempt >= 2 && attempt < 4)
        {
            openHelpCanvas("If you want to specify several objects, you need an 's' at the end in Spanish");
        }
        else if (answer_4 != textAnswer && attempt >= 4 && attempt < 7)
        {
            openHelpCanvas("una mochila, dos mochilas, ...");
        }
        else if (answer_1 != textAnswer && attempt >= 8)
        {
            placeholderText.text = "cinco ...";
            openHelpCanvas("una mochila, dos mochilas, ...");
        }

    }

    public void questionTime(string textAnswer, int attempt)
    {

        if (answer_5 == textAnswer)
        {
            openHelpCanvas("Correct!");
            question += 1;
            Checkbutton.enabled = false;
            StartCoroutine(clearBoard(3.0f));
        }
        else if (answer_1 != textAnswer && attempt >= 1 && attempt < 2)
        {
            openHelpCanvas("Something is wrong! Try it again.");
        }
        else if (answer_5 != textAnswer && attempt >= 2 && attempt < 5)
        {
            openHelpCanvas("I know this is hard! Maybe this will help");
            CheatsheetCanvas.SetActive(false);
            CheatsheetCanvasTime.SetActive(true);
        }
        else if (answer_5 != textAnswer && attempt == 5)
        {
            openHelpCanvas("Like in the previous tasks you need to put an 's' at the end!");
        }
        else if (answer_5 != textAnswer && attempt >= 6)
        {
            openHelpCanvas("las diez de la mañana -> ten o'clock in the morning");
        }
        else if (answer_1 != textAnswer && attempt >= 8)
        {
            inputText.text = "";
            placeholderText.text = "las nueve ...";
            openHelpCanvas("las diez de la mañana -> ten o'clock in the morning");
        }
    }

    IEnumerator clearBoard(float delay)
    {
        yield return new WaitForSeconds(delay);
        closeHelpCanvas();
        QuestionCanvas.SetActive(false);
        AnswerCanvas.SetActive(false);
        CheatsheetCanvas.SetActive(false);
        NextLecture.SetActive(true);
    }


    IEnumerator finishGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        closeHelpCanvas();
        QuestionText.text = "You did it! Click the button below for your next lecture";
        QuestionCanvas.SetActive(true);
        AnswerCanvas.SetActive(false);
        CheatsheetCanvas.SetActive(false);
    }

    IEnumerator Pause(float delay)
    {
        yield return new WaitForSeconds(delay);
        closeHelpCanvas();
        setBlackboard();
    }
}
