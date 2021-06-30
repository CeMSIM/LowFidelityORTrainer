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
    public GameObject ExamManager;

    public GameObject BeginDoffing;
    public GameObject EndDoffing;
    public GameObject EndDonning;

    public GameObject SelectProcedure;

    private UIManager UI;
    private ExamPPEManager EPP;
    private RSIManager RSI;

    public bool TutorialBool;
    void Start()
    {
        TutorialBool = false;
        //Acessing the UIManager Script
        UI = Manager.GetComponent<UIManager>();
        EPP = ExamManager.GetComponent<ExamPPEManager>();
        RSI = Manager.GetComponent<RSIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Making the answer check blank for exam mode
        if (UI.stop == 1)
        {
            UI.AnswerCheck.GetComponentInChildren<TextMeshProUGUI>().text = "";
            UI.UndoButton.gameObject.SetActive(false);
        }

    }


    //Functions to activate the chosen quiz mode

    public void ProcedureChoice()
    {
        SelectProcedure.gameObject.SetActive(false);
    }
    public void ActivateTutorial()
    {
        TutorialBool = true;
        Tutorial_Track.gameObject.SetActive(true);
        IntroScreen.gameObject.SetActive(false);
        Exam_Track.gameObject.SetActive(false);
        BeginDoffing.gameObject.SetActive(false);
        //EndDoffing.gameObject.SetActive(false);
        EndDonning.SetActive(false);

        RSI.IntubationScore.gameObject.SetActive(false);
        RSI.ExtubationScore.gameObject.SetActive(false);
        RSI.PostExtubationScore.gameObject.SetActive(false);
        RSI.SGAScore.gameObject.SetActive(false);
        RSI.PostSGAScore.gameObject.SetActive(false);
        RSI.SGAExtubationScore.gameObject.SetActive(false);
       
        
        
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
