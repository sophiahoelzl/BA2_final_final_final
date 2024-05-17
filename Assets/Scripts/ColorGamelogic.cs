using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorGamelogic : MonoBehaviour
{
    public Button Checkbutton;
    public GameObject CheatSheetColorCanvas;
    public GameObject ColorCanvas;
    public GameObject HelpCanvas;
    public Text helpText;
    public GameObject QuestionCanvas;
    public Text QuestionText;
    public GameObject ColorObjects;
    public GameObject nextLecture;

    private int mistake = 0;

    public GameObject podest;
    public GameObject blueObject;
    public GameObject redObject;
    public GameObject yellowObject;
    public GameObject purpleObject;
    public GameObject whiteObject;
    public GameObject orangeObject;
    public GameObject greenObject;

    public XRSocketInteractor blueSocket;
    public XRSocketInteractor redSocket;
    public XRSocketInteractor yellowSocket;
    public XRSocketInteractor purpleSocket;
    public XRSocketInteractor whiteSocket;
    public XRSocketInteractor orangeSocket;
    public XRSocketInteractor greenSocket;

    public GameObject Blue;
    public GameObject Red;
    public GameObject Purple;
    public GameObject Yellow;
    public GameObject White;
    public GameObject Orange;
    public GameObject Green;
    public GameObject Podest;

    private Vector3 originalPositionBlue;
    private Vector3 originalPositionRed;
    private Vector3 originalPositionYellow;
    private Vector3 originalPositionPurple;
    private Vector3 originalPositionGreen;
    private Vector3 originalPositionWhite;
    private Vector3 originalPositionOrange;


    public void Start()
    {
        originalPositionBlue = blueObject.transform.position;
        originalPositionRed = redObject.transform.position;
        originalPositionYellow = yellowObject.transform.position;
        originalPositionPurple = purpleObject.transform.position;
        originalPositionGreen = greenObject.transform.position;
        originalPositionWhite = whiteObject.transform.position;
        originalPositionOrange = orangeObject.transform.position;

    }

    public void setQuestion()
    {
        QuestionCanvas.SetActive(true);
        QuestionText.text = "Colors in Spanish";
        CheatSheetColorCanvas.SetActive(true);
        ColorCanvas.SetActive(true);
        ColorObjects.SetActive(true);
        nextLecture.SetActive(false);
    }

    public void Update()
    {
        if(mistake >= 3)
        {
            HelpCanvas.SetActive(true);
            helpText.text = "Look in the back where the art stuff is, I am sure you will find something useful there!";
        }
    }

    public void ResetPosition()
    {
        IXRSelectInteractable objNameBlueSocket = blueSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameRedSocket = redSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameYellowSocket = yellowSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameGreenSocket = greenSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameWhiteSocket = whiteSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNamePurpleSocket = purpleSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameOrangeSocket = orangeSocket.GetOldestInteractableSelected();

        blueSocket.interactionManager.SelectExit(blueSocket, objNameBlueSocket);
        redSocket.interactionManager.SelectExit(redSocket, objNameRedSocket);
        yellowSocket.interactionManager.SelectExit(yellowSocket, objNameYellowSocket);
        greenSocket.interactionManager.SelectExit(greenSocket, objNameGreenSocket);
        whiteSocket.interactionManager.SelectExit(whiteSocket, objNameWhiteSocket);
        purpleSocket.interactionManager.SelectExit(purpleSocket, objNamePurpleSocket);
        orangeSocket.interactionManager.SelectExit(orangeSocket, objNameOrangeSocket);

        blueObject.transform.position = originalPositionBlue;
        redObject.transform.position = originalPositionRed;
        yellowObject.transform.position = originalPositionYellow;
        purpleObject.transform.position = originalPositionPurple;
        greenObject.transform.position = originalPositionGreen;
        whiteObject.transform.position = originalPositionWhite;
        orangeObject.transform.position = originalPositionOrange;
    }

    public void CheckAnswer()
    {
        IXRSelectInteractable objNameBlueSocket = blueSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameRedSocket = redSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameYellowSocket = yellowSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameGreenSocket = greenSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameWhiteSocket = whiteSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNamePurpleSocket = purpleSocket.GetOldestInteractableSelected();
        IXRSelectInteractable objNameOrangeSocket = orangeSocket.GetOldestInteractableSelected();

        if(objNameBlueSocket.transform.name == "blue" 
            && objNameRedSocket.transform.name == "red" 
            && objNameYellowSocket.transform.name == "yellow" 
            && objNameGreenSocket.transform.name == "green"
            && objNameWhiteSocket.transform.name == "white"
            && objNamePurpleSocket.transform.name == "purple"
            && objNameOrangeSocket.transform.name == "orange"){
            HelpCanvas.SetActive(true);
            helpText.text = "Wow! Everything is correct!";
            StartCoroutine(finishGame(3.0f));
        }
        else
        {
            mistake += 1;
            HelpCanvas.SetActive(true);
            helpText.text = "Something is wrong, try again!";
            StartCoroutine(resetGame(3.0f));
        }
    }

    IEnumerator resetGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        HelpCanvas.SetActive(false);
        ResetPosition();
    }

    IEnumerator finishGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        QuestionText.text = "You did it! Thank you for playing";
        HelpCanvas.SetActive(false);
        ColorCanvas.SetActive(false);
        podest.SetActive(false);
        CheatSheetColorCanvas.SetActive(false);
    }

}
