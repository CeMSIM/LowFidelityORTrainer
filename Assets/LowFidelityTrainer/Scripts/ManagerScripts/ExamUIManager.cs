﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;




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
    public GameObject NumberText;

    public int N95DonWrongCount;
    public int GownDonWrongCount;
    public int GlovesDonWrongCount;
    public int N95DoffWrongCount;
    public int GownDoffWrongCount;
    public int GlovesDoffWrongCount;
    private int z;
    public QuestionsManager test;

    public GameObject N95DonFraction;
    public GameObject GownDonFraction;
    public GameObject GlovesDonFraction;
    public GameObject N95DoffFraction;
    public GameObject GownDoffFraction;
    public GameObject GlovesDoffFraction;

    public GameObject Undo;
    public GameObject Abutton;



    // Start is called before the first frame update
    void Start()
    {
        
       
        N95DoffWrongCount = 4;
        GownDoffWrongCount = 3;
        GlovesDoffWrongCount = 4;
        N95DonWrongCount = 4;
        GownDonWrongCount = 1;
        GlovesDonWrongCount = 2;
        //Accesing the UIManager Script
        UI = Managers.GetComponent<UIManager>();


        ExamChoicesInt = 0;



        UI.DoffingCheck.gameObject.SetActive(false);





    }

    // Update is called once per frame
    void Update()
    {
        

        if (Abutton.activeSelf)
        {
            Undo.gameObject.SetActive(false);
        }
        else if(ExamChoicesInt > 15)
        {
            Undo.gameObject.SetActive(false);
        }
        else
        {
            Undo.gameObject.SetActive(true);
        }

        //Displays the final quiz score for the donning and doffing of each item
        N95DonFraction.GetComponentInChildren<TextMeshProUGUI>().text = N95DonWrongCount.ToString() + "/4";
        GownDonFraction.GetComponentInChildren<TextMeshProUGUI>().text = GownDonWrongCount.ToString() + "/1";
        GlovesDonFraction.GetComponentInChildren<TextMeshProUGUI>().text = GlovesDonWrongCount.ToString() + "/2";
        N95DoffFraction.GetComponentInChildren<TextMeshProUGUI>().text = N95DoffWrongCount.ToString() + "/4";
        GownDoffFraction.GetComponentInChildren<TextMeshProUGUI>().text = GownDoffWrongCount.ToString() + "/3";
        GlovesDoffFraction.GetComponentInChildren<TextMeshProUGUI>().text = GlovesDoffWrongCount.ToString() + "/4";


        //Setting the answer choices and infotexts to the array of scriptable objects

        QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].Info;
        AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerA;
        AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerB;
        AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerC;
        AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerD;
        QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "Answer the questions/Select the next item of PPE";
        CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
        NumberText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].CurrentNumber;


        //Displays the Results Screen once the PPE is completely doffed
        if (ExamChoicesInt > 33)
        {
            UI.BG.gameObject.SetActive(true);
        }


        //Settinng the respective cecklist game objects to true once the PPE object is donned or doffed
        if (ExamChoicesInt == 1)
        {
            UI.HH1Check.gameObject.SetActive(true);

        }




        if (ExamChoicesInt == 6)
        {
            UI.N95DonCheck.gameObject.SetActive(true);

        }


        if (ExamChoicesInt == 7)
        {
            UI.HCDonCheck.gameObject.SetActive(true);
        }





        if (ExamChoicesInt == 8)
        {
            UI.EPDonCheck.gameObject.SetActive(true);
        }


        if (ExamChoicesInt == 9)
        {
            UI.SCDonCheck.gameObject.SetActive(true);
        }


        if (ExamChoicesInt == 11)
        {
            UI.GownDonCheck.gameObject.SetActive(true);
        }




        if (ExamChoicesInt == 12)
        {
            UI.HH2Check.gameObject.SetActive(true);
        }





        if (ExamChoicesInt == 15)
        {
            UI.GlovesDonCheck.gameObject.SetActive(true);
            UI.DonningCheck.gameObject.SetActive(false);
            UI.DoffingCheck.gameObject.SetActive(true);
        }




        if (ExamChoicesInt == 16)
        {
            UI.SCDoffCheck.gameObject.SetActive(true);
        }



        if (ExamChoicesInt > 20)
        {
            UI.GownDoffCheck.gameObject.SetActive(true);
        }




        if (ExamChoicesInt == 25)
        {
            UI.Anteroom.gameObject.SetActive(true);
            UI.GlovesDoffCheck.gameObject.SetActive(true);
        }




        if (ExamChoicesInt == 26)
        {
            UI.HH3Check.gameObject.SetActive(true);
        }





        if (ExamChoicesInt == 27)
        {
            UI.EPDoffCheck.gameObject.SetActive(true);
        }



        if (ExamChoicesInt == 28)
        {
            UI.HCDoffCheck.gameObject.SetActive(true);
        }



        if (ExamChoicesInt == 33)
        {
            UI.N95DoffCheck.gameObject.SetActive(true);
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



    // Checks to see if the question is answered correctly and deducts a point if the answer is incorrect
    public void N95DonWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt >1 && ExamChoicesInt <6)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }
        
        }

        if (z == UI.AnswersArrayD.Length)
        {
            N95DonWrongCount -= 1;
        }

        z = 0;
        
    }


    public void GownDonWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayD.Length)
        {
            GownDonWrongCount -= 1;
        }

        z = 0;

    }


    public void GlovesDonWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayD.Length)
        {
            GlovesDonWrongCount -= 1;
        }

        z = 0;

    }

    public void N95DoffWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayD.Length)
        {
            N95DoffWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDoffWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayD.Length)
        {
            GownDoffWrongCount -= 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayD.Length)
        {
            GlovesDoffWrongCount -= 1;
        }

        z = 0;

    }












    public void N95DonWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 1 && ExamChoicesInt < 6)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayC.Length)
        {
            N95DonWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDonWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayC.Length)
        {
            GownDonWrongCount -= 1;
        }

        z = 0;

    }


    public void GlovesDonWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayC.Length)
        {
            GlovesDonWrongCount -= 1;
        }

        z = 0;

    }

    public void N95DoffWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayC.Length)
        {
            N95DoffWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDoffWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayC.Length)
        {
            GownDoffWrongCount -= 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayC.Length)
        {
            GlovesDoffWrongCount -= 1;
        }

        z = 0;

    }











    public void N95DonWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 1 && ExamChoicesInt < 6)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayB.Length)
        {
            N95DonWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDonWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayB.Length)
        {
            GownDonWrongCount -= 1;
        }

        z = 0;

    }


    public void GlovesDonWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayB.Length)
        {
            GlovesDonWrongCount -= 1;
        }

        z = 0;

    }

    public void N95DoffWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayB.Length)
        {
            N95DoffWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDoffWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayB.Length)
        {
            GownDoffWrongCount -= 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayB.Length)
        {
            GlovesDoffWrongCount -= 1;
        }

        z = 0;

    }















    public void N95DonWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 1 && ExamChoicesInt < 6)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayA.Length)
        {
            N95DonWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDonWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayA.Length)
        {
            GownDonWrongCount -= 1;
        }

        z = 0;

    }


    public void GlovesDonWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayA.Length)
        {
            GlovesDonWrongCount -= 1;
        }

        z = 0;

    }

    public void N95DoffWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayA.Length)
        {
            N95DoffWrongCount -= 1;
        }

        z = 0;

    }


    public void GownDoffWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayA.Length)
        {
            GownDoffWrongCount -= 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == UI.AnswersArrayA.Length)
        {
            GlovesDoffWrongCount -= 1;
        }

        z = 0;

    }


}
