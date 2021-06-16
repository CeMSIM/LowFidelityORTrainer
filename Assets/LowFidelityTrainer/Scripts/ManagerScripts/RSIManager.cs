using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RSIManager : MonoBehaviour
{
    public QuestionsManager[] IntubationQuestions;
    public QuestionsManager[] SGAQuestions;
    public TextMesh[] AnswerChoicesA;
    public UIManager UI;
    public ExamUIManager EUI;
    public IntroScreenManager IS;

    public GameObject Manager;
    public GameObject ExamManager;

    public int IQ;
    public int SGA;

    public bool IQBool;
    public bool SGABool;

    public GameObject RSIChoice;
    // Start is called before the first frame update
    void Start()
    {
        SGA = 0;
        IQ = 0;
        RSIChoice.gameObject.SetActive(false);
        IQBool = false;
        SGABool = false;

        UI = Manager.GetComponent<UIManager>();
        EUI = ExamManager.GetComponent<ExamUIManager>();
        IS = Manager.GetComponent<IntroScreenManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (IQBool == true && SGABool == false)
        {
            EUI.QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].Info;
            EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerA;
            EUI.AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerB;
            EUI.AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerC;
            EUI.AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerD;
            EUI.QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "";
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
            EUI.NumberText.GetComponentInChildren<TextMeshProUGUI>().text = "TBD";
            UI.AnswerButtons.gameObject.SetActive(true);
        }


        if (IQBool == false && SGABool == true)
        {
            EUI.QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].Info;
            EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerA;
            EUI.AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerB;
            EUI.AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerC;
            EUI.AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerD;
            EUI.QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "";
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
            EUI.NumberText.GetComponentInChildren<TextMeshProUGUI>().text = "TBD";
            UI.AnswerButtons.gameObject.SetActive(true);
        }



        //Manages buttons that access the RSI section in tutorial mode


        if (UI.ChoicesInt == 15)
        {
            IS.EndDonning.gameObject.SetActive(true);
            IS.BeginDoffing.gameObject.SetActive(true);
        }


    }

    public void ChangeIntubationQuestion()
    {
        if (IQBool == true && IQ < 11 && IS.TutorialBool == false)
        {
            IQ += 1;
        }
    }

    public void ChangeSGAQuestion()
    {
        if (SGABool == true && SGA < 9 && IS.TutorialBool == false)
        {
            SGA += 1;
        }
    }

    public void ChangeIQBool()
    {
        IQBool = true;
        RSIChoice.gameObject.SetActive(false);
    }

    public void ChangeSGABool()
    {
        SGABool = true;
        RSIChoice.gameObject.SetActive(false);

    }

    public void ActivateRSI()
    {
        RSIChoice.gameObject.SetActive(true);
    }
}
