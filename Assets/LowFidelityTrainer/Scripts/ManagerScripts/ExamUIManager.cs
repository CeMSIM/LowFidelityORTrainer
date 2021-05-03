using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class ExamUIManager : MonoBehaviour
{
    public int ExamChoicesInt;

    private UIManager UI;
    
    public GameObject Managers;

    private QuestionsManager[] TextInfo;

    public GameObject AnswerAText;
    public GameObject AnswerBText;
    public GameObject AnswerCText;
    public GameObject AnswerDText;
    public GameObject QuestionInfoTextObject;
    public GameObject QuestText;
    public GameObject CurrentPPE;

    public QuestionsManager test;
    // Start is called before the first frame update
    void Start()
    {
        
        //Accesing the UIManager Script
        UI = Managers.GetComponent<UIManager>();
        
        
        ExamChoicesInt = 0;


        
        
  

        

    }

    // Update is called once per frame
    void Update()
    {
        //Setting the answer choices and infotexts to the array of scriptable objects

        QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].Info;
        AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerA;
        AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerB;
        AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerC;
        AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerD;
        QuestText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].QuestText;
        CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].CurrentObject;

        //Displays the Results Screen once the PPE is completely doffed
        if (ExamChoicesInt > 33)
        {
            UI.BG.gameObject.SetActive(true);
        }


        //Settinng the respective cecklist game objects to true once the PPE object is donned or doffed
        if (ExamChoicesInt > 0)
        {
            UI.HH1Check.gameObject.SetActive(true);

        }
        else
        {

            UI.HH1Check.gameObject.SetActive(false);
        }



        if (ExamChoicesInt > 5)
        {
            UI.N95DonCheck.gameObject.SetActive(true);

        }
        else
        {
            UI.N95DonCheck.gameObject.SetActive(false);
        }

        if (ExamChoicesInt > 6)
        {
            UI.HCDonCheck.gameObject.SetActive(true);
        }


        else
        {
            UI.HCDonCheck.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 7)
        {
            UI.EPDonCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.EPDonCheck.gameObject.SetActive(false);
        }



        if (ExamChoicesInt > 8)
        {
            UI.SCDonCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.SCDonCheck.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 10)
        {
            UI.GownDonCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.GownDonCheck.gameObject.SetActive(false);
        }



        if (ExamChoicesInt > 11)
        {
            UI.HH2Check.gameObject.SetActive(true);
        }

        else
        {
            UI.HH2Check.gameObject.SetActive(false);
        }



        if (ExamChoicesInt > 14)
        {
            UI.GlovesDonCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.GlovesDonCheck.gameObject.SetActive(false);
        }



        if (ExamChoicesInt > 15)
        {
            UI.SCDoffCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.SCDoffCheck.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 19)
        {
            UI.GownDoffCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.GownDoffCheck.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 24)
        {
            UI.Anteroom.gameObject.SetActive(true);
            UI.GlovesDoffCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.GlovesDoffCheck.gameObject.SetActive(false);
            UI.Anteroom.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 25)
        {
            UI.HH3Check.gameObject.SetActive(true);
        }

        else
        {
            UI.HH3Check.gameObject.SetActive(false);
        }



        if (ExamChoicesInt > 26)
        {
            UI.EPDoffCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.EPDoffCheck.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 27)
        {
            UI.HCDoffCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.HCDoffCheck.gameObject.SetActive(false);
        }


        if (ExamChoicesInt > 32)
        {
            UI.N95DoffCheck.gameObject.SetActive(true);
        }

        else
        {
            UI.N95DoffCheck.gameObject.SetActive(false);
        }



    }


    //Functions to manage the choices
    public void ChangeExamOptions()
    {
        ExamChoicesInt += 1;
    }

    public void UndoExamButton()
    {
        ExamChoicesInt -= 1;
    }

    public void ResetExam()
    {
        ExamChoicesInt = 0;
    }
}
