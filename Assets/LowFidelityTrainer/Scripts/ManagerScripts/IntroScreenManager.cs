using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroScreenManager : MonoBehaviour
{
    public GameObject Tutorial_Track;
    public GameObject Exam_Track;

    public GameObject IntroScreen;
    public GameObject Manager;

    public GameObject BeginDoffing;
    public GameObject EndDoffing;

    private UIManager UI;
    void Start()
    {
        //Acessing the UIManager Script
        UI = Manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Making the answer check blank for exam mode
        if (UI.stop == 1)
        {
            UI.AnswerCheck.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }

    }

    //Functions to activate the chosen quiz mode
    public void ActivateTutorial()
    {

        Tutorial_Track.gameObject.SetActive(true);
        IntroScreen.gameObject.SetActive(false);
        Exam_Track.gameObject.SetActive(false);
        BeginDoffing.gameObject.SetActive(false);
        EndDoffing.gameObject.SetActive(false);
        
        
    }

    public void ActivateExam()
    {
        
        IntroScreen.gameObject.SetActive(false);
        BeginDoffing.gameObject.SetActive(true);
        EndDoffing.gameObject.SetActive(true);
        //Tutorial_Track.gameObject.SetActive(false);
        UI.stop = 1;
    }
}
