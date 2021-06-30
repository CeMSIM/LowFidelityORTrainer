using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;




public class ExamUIManager : MonoBehaviour
{
    public int ExamChoicesInt;

    private UIManager UI;
    private ExamPPEManager EPP;
    private RSIManager RSIM;

    public GameObject Managers;
    public GameObject ExamManagers;

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

    public GameObject MedSelect1;
    public GameObject MedSelect2;
    public GameObject MedSelect3;

    // Start is called before the first frame update
    void Start()
    {
        
       
        N95DoffWrongCount = 0;
        GownDoffWrongCount = 0;
        GlovesDoffWrongCount = 0;
        N95DonWrongCount = 0;
        GownDonWrongCount = 0;
        GlovesDonWrongCount = 0;
        //Accesing other scripts
        UI = Managers.GetComponent<UIManager>();
        EPP = ExamManagers.GetComponent<ExamPPEManager>();
        RSIM = Managers.GetComponent<RSIManager>();


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
        QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "Select the items to don and answer the associated questions. When you have selected all the PPE needed, press Finish";
        CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
        NumberText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].CurrentNumber;





    }


    //Functions to manage the choices
    public void ChangeExamOptions()
    {
        if (RSIM.IQBool == false && RSIM.SGABool == false)
        {
            ExamChoicesInt += 1;
        }
    }

    public void UndoExamButton()
    {
        ExamChoicesInt -= 1;
    }

    public void ResetExam()
    {
        ExamChoicesInt = 0;
        EPP.Doffing = false;

        EPP.N95Bool = true;
        EPP.HCBool = true;
        EPP.SCBool = true;
        EPP.EPBool = true;
        EPP.GlovesBool = true;
        EPP.GownBool = true;


        N95DonWrongCount = 0;
        GownDonWrongCount = 0;
        GlovesDonWrongCount = 0;
        N95DoffWrongCount = 0;
        GownDoffWrongCount = 0;
        GlovesDoffWrongCount = 0;

        foreach (var obj in EPP.ChecklistObjects)
        {
            Destroy(obj);
        }
    }



    // Checks to see if the question is answered correctly and deducts a point if the answer is incorrect

    public void MedicationsCheckA()
    {
        MedSelect1.GetComponentInChildren<TextMeshProUGUI>().text = AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect2.GetComponentInChildren<TextMeshProUGUI>().text = AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect3.GetComponentInChildren<TextMeshProUGUI>().text = AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    public void MedicationsCheckB()
    {
        MedSelect1.GetComponentInChildren<TextMeshProUGUI>().text = AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect2.GetComponentInChildren<TextMeshProUGUI>().text = AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect3.GetComponentInChildren<TextMeshProUGUI>().text = AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    public void MedicationsCheckC()
    {
        MedSelect1.GetComponentInChildren<TextMeshProUGUI>().text = AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect2.GetComponentInChildren<TextMeshProUGUI>().text = AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect3.GetComponentInChildren<TextMeshProUGUI>().text = AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text;
    }

    public void MedicationsCheckD()
    {
        MedSelect1.GetComponentInChildren<TextMeshProUGUI>().text = AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect2.GetComponentInChildren<TextMeshProUGUI>().text = AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text;
        MedSelect3.GetComponentInChildren<TextMeshProUGUI>().text = AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text;
    }
    public void N95DonWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt >1 && ExamChoicesInt <6)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }
        
        }

        if (z == 1)
        {
            N95DonWrongCount += 1;
        }

        z = 0;
        
    }


    public void GownDonWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDonWrongCount += 1;
        }

        z = 0;

    }


    public void GlovesDonWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDonWrongCount += 1;
        }

        z = 0;

    }

    public void N95DoffWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DoffWrongCount += 1;
        }

        z = 0;

    }


    public void GownDoffWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDoffWrongCount += 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongD()
    {

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDoffWrongCount += 1;
        }

        z = 0;

    }












    public void N95DonWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 1 && ExamChoicesInt < 6)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DonWrongCount += 1;
        }

        z = 0;

    }


    public void GownDonWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDonWrongCount += 1;
        }

        z = 0;

    }


    public void GlovesDonWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDonWrongCount += 1;
        }

        z = 0;

    }

    public void N95DoffWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DoffWrongCount += 1;
        }

        z = 0;

    }


    public void GownDoffWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDoffWrongCount += 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongC()
    {

        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDoffWrongCount += 1;
        }

        z = 0;

    }











    public void N95DonWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 1 && ExamChoicesInt < 6)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DonWrongCount += 1;
        }

        z = 0;

    }


    public void GownDonWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDonWrongCount += 1;
        }

        z = 0;

    }


    public void GlovesDonWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDonWrongCount += 1;
        }

        z = 0;

    }

    public void N95DoffWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DoffWrongCount += 1;
        }

        z = 0;

    }


    public void GownDoffWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDoffWrongCount += 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongB()
    {

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDoffWrongCount += 1;
        }

        z = 0;

    }















    public void N95DonWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 1 && ExamChoicesInt < 6)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DonWrongCount += 1;
        }

        z = 0;

    }


    public void GownDonWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt == 10)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDonWrongCount += 1;
        }

        z = 0;

    }


    public void GlovesDonWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 12 && ExamChoicesInt < 15)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDonWrongCount += 1;
        }

        z = 0;

    }

    public void N95DoffWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 28 && ExamChoicesInt < 33)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            N95DoffWrongCount += 1;
        }

        z = 0;

    }


    public void GownDoffWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 16 && ExamChoicesInt < 20)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GownDoffWrongCount += 1;
        }

        z = 0;

    }



    public void GlovesDoffWrongA()
    {

        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (ExamChoicesInt > 20 && ExamChoicesInt < 25)
            {
                if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            GlovesDoffWrongCount += 1;
        }

        z = 0;

    }














}
