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
    private ExamPPEManager EPP;
    private jsonParser jsonP;

    public GameObject Manager;
    public GameObject ExamManager;
    public GameObject jsonManager;


    public int IQ;
    public int IQQuestionNumber;
    public int SGA;
    public int SGAQuestionNumber;

    public bool IQBool;
    public bool IQFinalBool;
    public bool SGABool;
    public bool SGAFinalBool;

    public GameObject RSIChoice;

    public GameObject ExtubationResults;
    public GameObject IntubationResults;
    public GameObject PostExtubationResults;
    public GameObject SGAResults;
    public GameObject PostSGAResults;
    public GameObject IntubationBG;
    public GameObject SGABG;

    public int IntCorrectCount;
    public int PostIntCorrectCount;
    public int ExtCorrectCount;
    public int SGACorrectCount;
    public int PostSGACorrectCount;


    public GameObject IntubationScore;
    public GameObject ExtubationScore;
    public GameObject PostExtubationScore;
    public GameObject SGAScore;
    public GameObject PostSGAScore;
    public GameObject SGAExtubationScore;

    public int z;


    public GameObject ExtraExtQuestion;
    // Start is called before the first frame update
    void Start()
    {
        SGA = 0;
        IQ = 0;
        RSIChoice.gameObject.SetActive(false);
        IQBool = false;
        IQFinalBool = false;
        SGABool = false;
        SGAFinalBool = false;

        ExtubationResults.gameObject.SetActive(false);
        IntubationResults.gameObject.SetActive(false);
        PostExtubationResults.gameObject.SetActive(false);
        SGAResults.gameObject.SetActive(false);
        PostSGAResults.gameObject.SetActive(false);
        IntubationBG.gameObject.SetActive(false);
        SGABG.gameObject.SetActive(false);

        UI = Manager.GetComponent<UIManager>();
        EUI = ExamManager.GetComponent<ExamUIManager>();
        IS = Manager.GetComponent<IntroScreenManager>();
        EPP = ExamManager.GetComponent<ExamPPEManager>();
        jsonP = jsonManager.GetComponent<jsonParser>();

        IntCorrectCount = 0;
        ExtCorrectCount = 0;
        PostIntCorrectCount = 0;
        SGACorrectCount = 0;
        PostSGACorrectCount = 0;

    }

    // Update is called once per frame
    void Update()
    {

        SGAQuestionNumber = SGA + 1;
        IQQuestionNumber = IQ + 1;
        if (SGAFinalBool == true)
        {
            ExtraExtQuestion.gameObject.SetActive(false);
        }
        if (IQBool == true && SGABool == false)
        {
                EUI.QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.myIntubationQuestions.Intubation[IQ].QuestionsText;
                EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.myIntubationQuestions.Intubation[IQ].OptionA;
                EUI.AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.myIntubationQuestions.Intubation[IQ].OptionB;
                EUI.AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.myIntubationQuestions.Intubation[IQ].OptionC;
                EUI.AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.myIntubationQuestions.Intubation[IQ].OptionD;
                EUI.QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "";
                EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
                EUI.NumberText.GetComponentInChildren<TextMeshProUGUI>().text = IQQuestionNumber.ToString();


            //EUI.QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].Info;
            //EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerA;
            //EUI.AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerB;
            //EUI.AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerC;
            //EUI.AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = IntubationQuestions[IQ].AnswerD;
            //EUI.QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "";
            //EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
            //EUI.NumberText.GetComponentInChildren<TextMeshProUGUI>().text = IQQuestionNumber.ToString();
            UI.AnswerButtons.gameObject.SetActive(true);

            SGAResults.gameObject.SetActive(false);
            PostSGAResults.gameObject.SetActive(false);
            SGABG.gameObject.SetActive(false);

        }

        if (EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text == "")
        {
            UI.AnswerButtons.gameObject.SetActive(false);
        }

        if (IQBool == false && SGABool == true)
        {

            EUI.QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.mySGAIntubationQuestions.SGA[SGA].QuestionsText;
            EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.mySGAIntubationQuestions.SGA[SGA].OptionA;
            EUI.AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.mySGAIntubationQuestions.SGA[SGA].OptionB;
            EUI.AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.mySGAIntubationQuestions.SGA[SGA].OptionC;
            EUI.AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = jsonP.mySGAIntubationQuestions.SGA[SGA].OptionD;
            EUI.QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "";
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
            EUI.NumberText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestionNumber.ToString();




            //EUI.QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].Info;
            //EUI.AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerA;
            //EUI.AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerB;
            //EUI.AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerC;
            //EUI.AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestions[SGA].AnswerD;
            //EUI.QuestText.GetComponentInChildren<TextMeshProUGUI>().text = "";
            //EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text = "";
            //EUI.NumberText.GetComponentInChildren<TextMeshProUGUI>().text = SGAQuestionNumber.ToString();
            UI.AnswerButtons.gameObject.SetActive(true);

            IntubationBG.gameObject.SetActive(false);
        }



        //Manages buttons that access the RSI section in tutorial mode


        if (IS.TutorialBool == true)
        {
            if (UI.ChoicesInt == 15 && EPP.ButtonActive == false)
            {
                IS.EndDonning.gameObject.SetActive(true);
            }
            else
            {
                IS.EndDonning.gameObject.SetActive(false);
            }








        }
        



        IntubationScore.GetComponentInChildren<TextMeshProUGUI>().text = IntCorrectCount.ToString() + "/4";
        if (IQFinalBool == true)
        {
            ExtubationScore.GetComponentInChildren<TextMeshProUGUI>().text = ExtCorrectCount.ToString() + "/4";
        }
        else if ( SGAFinalBool == true)
        {
            ExtubationScore.GetComponentInChildren<TextMeshProUGUI>().text = ExtCorrectCount.ToString() + "/3";
        }
        PostExtubationScore.GetComponentInChildren<TextMeshProUGUI>().text = PostIntCorrectCount.ToString() + "/3";
        SGAScore.GetComponentInChildren<TextMeshProUGUI>().text = SGACorrectCount.ToString() + "/3";
        SGAExtubationScore.GetComponentInChildren<TextMeshProUGUI>().text = ExtCorrectCount.ToString() + "/4";
        PostSGAScore.GetComponentInChildren<TextMeshProUGUI>().text = PostSGACorrectCount.ToString() + "/2";

    }

    public void ChangeIntubationQuestion()
    {
        if (IQBool == true && IQ < 12 && IS.TutorialBool == false)
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
        IQFinalBool = true;
    }

    public void ChangeSGABool()
    {
        SGABool = true;
        RSIChoice.gameObject.SetActive(false);
        SGAFinalBool = true;

    }

    public void ActivateRSI()
    {
        RSIChoice.gameObject.SetActive(true);
    }

    public void ReturnToMainRSI()
    {
        ExtubationResults.gameObject.SetActive(false);
        IntubationResults.gameObject.SetActive(false);
        PostExtubationResults.gameObject.SetActive(false);
        SGAResults.gameObject.SetActive(false);
        PostSGAResults.gameObject.SetActive(false);        
        if (IQFinalBool == true)
        {
            IntubationBG.gameObject.SetActive(true);
        }
        else if (SGAFinalBool == true)
        {
            SGABG.gameObject.SetActive(true);
        }
    }


    public void ActivateIR()
    {
        IntubationResults.gameObject.SetActive(true);
    }

    public void ActivateER()
    {
        ExtubationResults.gameObject.SetActive(true);
        IntubationBG.gameObject.SetActive(false);
        SGABG.gameObject.SetActive(false);
    }

    public void ActivatePER()
    {
        PostExtubationResults.gameObject.SetActive(true);
    }

    public void ActivateSGAR()
    {
        SGAResults.gameObject.SetActive(true);
        SGABG.gameObject.SetActive(false);
    }

    public void ActivatePSGAR()
    {
        PostSGAResults.gameObject.SetActive(true);
        SGABG.gameObject.SetActive(false);
    }

    public void FinishRSIReview()
    {
        ExtubationResults.gameObject.SetActive(false);
        IntubationResults.gameObject.SetActive(false);
        PostExtubationResults.gameObject.SetActive(false);
        SGAResults.gameObject.SetActive(false);
        PostSGAResults.gameObject.SetActive(false);
        IntubationBG.gameObject.SetActive(false);
        SGABG.gameObject.SetActive(false);
    }




    public void IntCorrectA()
    {
        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (IQ >= 1 && IQ < 5)
            {
                if (EUI.AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            IntCorrectCount += 1;
        }

        z = 0;
    }


    public void IntCorrectB()
    {
        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (IQ >= 1 && IQ < 5)
            {
                if (EUI.AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            IntCorrectCount += 1;
        }

        z = 0;
    }


    public void IntCorrectC()
    {
        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (IQ >= 1 && IQ < 5)
            {
                if (EUI.AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            IntCorrectCount += 1;
        }

        z = 0;
    }



    public void IntCorrectD()
    {
        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (IQ >= 1 && IQ < 5)
            {
                if (EUI.AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            IntCorrectCount += 1;
        }

        z = 0;
    }



    public void ExtCorrectA()
    {
        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (IQ >= 5 && IQ < 9)
            {
                if (EUI.AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }
            else if (SGA >= 4 && SGA < 8)
            {
                if (EUI.AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            ExtCorrectCount += 1;
        }

        z = 0;
    }


    public void ExtCorrectB()
    {
        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (IQ >= 5 && IQ < 9)
            {
                if (EUI.AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }

            }
            else if (SGA >= 4 && SGA < 8)
            {
                if (EUI.AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            ExtCorrectCount += 1;
        }

        z = 0;
    }



    public void ExtCorrectC()
    {
        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (IQ >= 5 && IQ < 9)
            {
                if (EUI.AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }

            }
            else if (SGA >= 4 && SGA < 8)
            {
                if (EUI.AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            ExtCorrectCount += 1;
        }

        z = 0;
    }



    public void ExtCorrectD()
    {
        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (IQ >= 5 && IQ < 9)
            {
                if (EUI.AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }
            else if (SGA >= 4 && SGA < 8)
            {
                if (EUI.AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            ExtCorrectCount += 1;
        }

        z = 0;
    }






    public void PostIntCorrectA()
    {
        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (IQ >= 9 && IQ < 12)
            {
                if (EUI.AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostIntCorrectCount += 1;
        }

        z = 0;
    }



    public void PostIntCorrectB()
    {
        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (IQ >= 9 && IQ < 12)
            {
                if (EUI.AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostIntCorrectCount += 1;
        }

        z = 0;
    }



    public void PostIntCorrectC()
    {
        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (IQ >= 9 && IQ < 12)
            {
                if (EUI.AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostIntCorrectCount += 1;
        }

        z = 0;
    }



    public void PostIntCorrectD()
    {
        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (IQ >= 9 && IQ < 12)
            {
                if (EUI.AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostIntCorrectCount += 1;
        }

        z = 0;
    }






    public void SGACorrectA()
    {
        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (SGA >= 1 && SGA < 4)
            {
                if (EUI.AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            SGACorrectCount += 1;
        }

        z = 0;
    }



    public void SGACorrectB()
    {
        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (SGA >= 1 && SGA < 4)
            {
                if (EUI.AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            SGACorrectCount += 1;
        }

        z = 0;
    }



    public void SGACorrectC()
    {
        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (SGA >= 1 && SGA < 4)
            {
                if (EUI.AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            SGACorrectCount += 1;
        }

        z = 0;
    }



    public void SGACorrectD()
    {
        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (SGA >= 1 && SGA < 4)
            {
                if (EUI.AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            SGACorrectCount += 1;
        }

        z = 0;
    }



    public void PostSGACorrectA()
    {
        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (SGA >= 8 && SGA < 10)
            {
                if (EUI.AnswerAText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayA[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostSGACorrectCount += 1;
        }

        z = 0;
    }



    public void PostSGACorrectB()
    {
        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (SGA >= 8 && SGA < 10)
            {
                if (EUI.AnswerBText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayB[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostSGACorrectCount += 1;
        }

        z = 0;
    }



    public void PostSGACorrectC()
    {
        for (int i = 0; i < UI.AnswersArrayC.Length; i++)
        {
            if (SGA >= 8 && SGA < 10)
            {
                if (EUI.AnswerCText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayC[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostSGACorrectCount += 1;
        }

        z = 0;
    }



    public void PostSGACorrectD()
    {
        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (SGA >= 8 && SGA < 10)
            {
                if (EUI.AnswerDText.GetComponentInParent<TextMeshProUGUI>().text == UI.AnswersArrayD[i])
                {
                    z += 1;
                }
            }

        }

        if (z == 1)
        {
            PostSGACorrectCount += 1;
        }

        z = 0;
    }
}
