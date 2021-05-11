
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.IO;
using UnityEngine.EventSystems;


//Creating a struct for the different text objects
[System.Serializable]
public struct UIElements
{
    

    [SerializeField] TextMeshProUGUI questionInfoTextObject;
    public TextMeshProUGUI QuestionInfoTextObject { get { return questionInfoTextObject; } }

    [SerializeField] TextMeshProUGUI answerAInfoTextObject;
    public TextMeshProUGUI AnswerAInfoTextObject { get { return answerAInfoTextObject; } }

    [SerializeField] TextMeshProUGUI answerBInfoTextObject;
    public TextMeshProUGUI AnswerBInfoTextObject { get { return answerBInfoTextObject; } }

    [SerializeField] TextMeshProUGUI answerCInfoTextObject;
    public TextMeshProUGUI AnswerCInfoTextObject { get { return answerCInfoTextObject; } }

    [SerializeField] TextMeshProUGUI answerDInfoTextObject;
    public TextMeshProUGUI AnswerDInfoTextObject { get { return answerDInfoTextObject; } }

    [SerializeField] TextMeshProUGUI questTextObject;
    public TextMeshProUGUI QuestTextObject { get { return questTextObject; } }

    [SerializeField] TextMeshProUGUI currentObjectText;
    public TextMeshProUGUI CurrentObjectText { get { return currentObjectText; } }


    [SerializeField] TextMeshProUGUI currentNumberText;
    public TextMeshProUGUI CurrentNumberText { get { return currentNumberText; } }
}

public class UIManager : MonoBehaviour
{
    public int QuestionNumber;
    public int stop;
    public QuestionsManager test;

    public QuestionsManager HH1;
    public QuestionsManager HH2;
    [Space]
    public QuestionsManager N951;
    public QuestionsManager N952;
    public QuestionsManager N953;
    public QuestionsManager N954;
    public QuestionsManager N955;
    [Space]
    public QuestionsManager HC1;
    [Space]
    public QuestionsManager EP1;
    [Space]
    public QuestionsManager SC1;
    [Space]
    public QuestionsManager Gown1;
    public QuestionsManager Gown2;
    [Space]
    public QuestionsManager Gloves1;
    public QuestionsManager Gloves2;
    [Space]
    public QuestionsManager DonF;
    [Space]
    [Space]
    [Space]
    public QuestionsManager SCDoff1;
    [Space]
    public QuestionsManager GownDoff1;
    public QuestionsManager GownDoff2;
    public QuestionsManager GownDoff3;
    public QuestionsManager GownDoff4;
    [Space]
    public QuestionsManager GlovesDoff1;
    public QuestionsManager GlovesDoff2;
    public QuestionsManager GlovesDoff3;
    public QuestionsManager GlovesDoff4;
    public QuestionsManager GlovesDoff5;
    [Space]
    public QuestionsManager HH3;
    [Space]
    public QuestionsManager EPDoff1;
    [Space]
    public QuestionsManager HCDoff1;
    [Space]
    public QuestionsManager N95Doff1;
    public QuestionsManager N95Doff2;
    public QuestionsManager N95Doff3;
    public QuestionsManager N95Doff4;
    public QuestionsManager N95Doff5;
    [Space]
    public QuestionsManager End;


    public int ChoicesInt;
    public GameObject AnswerButtons;
    public QuestionsManager[] TextInfo;
    [SerializeField] UIElements uIElements;
    public string[] AnswersArrayA;
    public string[] AnswersArrayB;
    public string[] AnswersArrayC;
    public string[] AnswersArrayD;

    public GameObject HH1Check;
    public GameObject N95DonCheck;
    public GameObject HCDonCheck;

    public GameObject EPDonCheck;
    public GameObject SCDonCheck;
    public GameObject GownDonCheck;
    public GameObject HH2Check;
    public GameObject GlovesDonCheck;
    [Space]
    [Space]
    public GameObject SCDoffCheck;
    public GameObject GownDoffCheck;
    public GameObject GlovesDoffCheck;
    public GameObject Anteroom;
    public GameObject HH3Check;
    public GameObject EPDoffCheck;
    public GameObject HCDoffCheck;
    public GameObject N95DoffCheck;
    public GameObject DonningCheck;
    public GameObject DoffingCheck;

    public GameObject BG;

    public GameObject AnswerCheck;
    public GameObject QuestionNumberText;
    public GameObject UndoButton;

    public int y;


    public GameObject N95DonFraction;
    public GameObject GownDonFraction;
    public GameObject GlovesDonFraction;
    public GameObject N95DoffFraction;
    public GameObject GownDoffFraction;
    public GameObject GlovesDoffFraction;
    private void Start()
    {
        //Integer used to prevent UIManager and ExamUIManager from conflicting
        stop = 0;
        //Make the answer check initially blank
        AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "";
        //Setting the final screen to false and creating ints for question changes
        BG.gameObject.SetActive(false);
        y = 0;
        
        ChoicesInt = 0;

        //Adding the scriptable objects to the array
        TextInfo = new QuestionsManager[35];
        TextInfo[0] = test;
        TextInfo[1] = HH1;

        TextInfo[2] = N951;
        TextInfo[3] = N952;
        TextInfo[4] = N953;
        TextInfo[5] = N954;
        TextInfo[6] = N955;

        TextInfo[7] = HC1;

        TextInfo[8] = EP1;

        TextInfo[9] = SC1;

        TextInfo[10] = Gown1;
        TextInfo[11] = Gown2;

        TextInfo[12] = HH2;
        TextInfo[13] = Gloves1;
        TextInfo[14] = Gloves2;

        TextInfo[15] = DonF;

        TextInfo[16] = SCDoff1;

        TextInfo[17] = GownDoff1;
        TextInfo[18] = GownDoff2;
        TextInfo[19] = GownDoff3;
        TextInfo[20] = GownDoff4;

        TextInfo[21] = GlovesDoff1;
        TextInfo[22] = GlovesDoff2;
        TextInfo[23] = GlovesDoff3;
        TextInfo[24] = GlovesDoff4;
        TextInfo[25] = GlovesDoff5;

        TextInfo[26] = HH3;

        TextInfo[27] = EPDoff1;

        TextInfo[28] = HCDoff1;

        TextInfo[29] = N95Doff1;
        TextInfo[30] = N95Doff2;
        TextInfo[31] = N95Doff3;
        TextInfo[32] = N95Doff4;
        TextInfo[33] = N95Doff5;

        TextInfo[34] = End;

        DoffingCheck.gameObject.SetActive(false);
    }

    private void Update()
    {

        if (ChoicesInt > 15 && stop == 0)
        {
            UndoButton.gameObject.SetActive(false);

        }

        //if tutorial is chosen, then the numbers and questions will correspond accordingly
        
        

        //Settinng the respective cecklist game objects to true once the PPE object is donned or doffed
        if (stop == 0)
        {
            N95DonFraction.GetComponentInChildren<TextMeshProUGUI>().text = "";
            GownDonFraction.GetComponentInChildren<TextMeshProUGUI>().text = "";
            GlovesDonFraction.GetComponentInChildren<TextMeshProUGUI>().text = "";
            N95DoffFraction.GetComponentInChildren<TextMeshProUGUI>().text = "";
            GownDoffFraction.GetComponentInChildren<TextMeshProUGUI>().text = "";
            GlovesDoffFraction.GetComponentInChildren<TextMeshProUGUI>().text = "";
            if (ChoicesInt > 0)
            {
                HH1Check.gameObject.SetActive(true);

            }
            else
            {

                HH1Check.gameObject.SetActive(false);
            }



            if (ChoicesInt > 5)
            {
                N95DonCheck.gameObject.SetActive(true);

            }
            else
            {
                N95DonCheck.gameObject.SetActive(false);
            }

            if (ChoicesInt > 6)
            {
                HCDonCheck.gameObject.SetActive(true);
            }



            else
            {
                HCDonCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 7)
            {
                EPDonCheck.gameObject.SetActive(true);
            }

            else
            {
                EPDonCheck.gameObject.SetActive(false);
            }



            if (ChoicesInt > 8)
            {
                SCDonCheck.gameObject.SetActive(true);
            }

            else
            {
                SCDonCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 10)
            {
                GownDonCheck.gameObject.SetActive(true);
            }

            else
            {
                GownDonCheck.gameObject.SetActive(false);
            }



            if (ChoicesInt > 11)
            {
                HH2Check.gameObject.SetActive(true);
            }

            else
            {
                HH2Check.gameObject.SetActive(false);
            }



            if (ChoicesInt > 14)
            {
                GlovesDonCheck.gameObject.SetActive(true);
                DonningCheck.gameObject.SetActive(false);
                DoffingCheck.gameObject.SetActive(true);
            }

            else
            {
                GlovesDonCheck.gameObject.SetActive(false);
            }



            if (ChoicesInt > 15)
            {
                SCDoffCheck.gameObject.SetActive(true);
            }

            else
            {
                SCDoffCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 19)
            {
                GownDoffCheck.gameObject.SetActive(true);
            }

            else
            {
                GownDoffCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 24)
            {
                Anteroom.gameObject.SetActive(true);
                GlovesDoffCheck.gameObject.SetActive(true);
            }

            else
            {
                GlovesDoffCheck.gameObject.SetActive(false);
                Anteroom.gameObject.SetActive(false);
            }


            if (ChoicesInt > 25)
            {
                HH3Check.gameObject.SetActive(true);
            }

            else
            {
                HH3Check.gameObject.SetActive(false);
            }



            if (ChoicesInt > 26)
            {
                EPDoffCheck.gameObject.SetActive(true);
            }

            else
            {
                EPDoffCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 27)
            {
                HCDoffCheck.gameObject.SetActive(true);
            }

            else
            {
                HCDoffCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 32)
            {
                N95DoffCheck.gameObject.SetActive(true);
            }

            else
            {
                N95DoffCheck.gameObject.SetActive(false);
            }


            if (ChoicesInt > 33)
            {
                BG.gameObject.SetActive(true);
            }
        }
            if (uIElements.AnswerAInfoTextObject.text == "")
            {
                AnswerButtons.gameObject.SetActive(false);
            }
            else
            {
                AnswerButtons.gameObject.SetActive(true);
            }
        
            //Makes sure the questions change due to choices int only if in tutorial mode
        if (stop == 0)
        {
            uIElements.QuestionInfoTextObject.text = TextInfo[ChoicesInt].Info;
            uIElements.AnswerAInfoTextObject.text = TextInfo[ChoicesInt].AnswerA;
            uIElements.AnswerBInfoTextObject.text = TextInfo[ChoicesInt].AnswerB;
            uIElements.AnswerCInfoTextObject.text = TextInfo[ChoicesInt].AnswerC;
            uIElements.AnswerDInfoTextObject.text = TextInfo[ChoicesInt].AnswerD;
            uIElements.QuestTextObject.text = TextInfo[ChoicesInt].QuestText;
            uIElements.CurrentObjectText.text = TextInfo[ChoicesInt].CurrentObject;
            uIElements.CurrentNumberText.text = TextInfo[ChoicesInt].CurrentNumber;
        }

    }

    public void ChangeOptionsA()
    {
        //Functions for changing options and changing the check text
        for (int i = 0; i < AnswersArrayA.Length; i++)
        {
            if (uIElements.AnswerAInfoTextObject.text == AnswersArrayA[i])
            {
                
                y += 1;
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Correct";
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.green;
                ChoicesInt += 1;
            }
            if (y < 1)
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Wrong";
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.red;
            }

            
        }

        y = 0;
    }

    public void ChangeOptionsB()
    {
        for (int i = 0; i < AnswersArrayB.Length; i++)
        {
            if (uIElements.AnswerBInfoTextObject.text == AnswersArrayB[i])
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.green;
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Correct";
                y += 1;
               
    
                ChoicesInt += 1;
            }
            if (y < 1)
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Wrong";
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.red;
            }
        }

        y = 0;
    }

    public void ChangeOptionsC()
    {
        for (int i = 0; i < AnswersArrayC.Length; i++)
        {
            if (uIElements.AnswerCInfoTextObject.text == AnswersArrayC[i])
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.green;
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Correct";
                y += 1;
                
                
                ChoicesInt += 1;
            }

            if (y< 1)
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Wrong";
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.red;
            }
        }
        y = 0;
    }

    public void ChangeOptionsD()
    {
        for (int i = 0; i < AnswersArrayD.Length; i++)
        {
            if (uIElements.AnswerDInfoTextObject.text == AnswersArrayD[i])
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.green;
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Correct";
                y += 1;
               
                
                ChoicesInt += 1;
            }

            if (y < 1)
            {
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().text = "Wrong";
                AnswerCheck.GetComponentInParent<TextMeshProUGUI>().color = Color.red;
            }
        }
        y = 0;
    }

    //Functions only allow the payer to go from PPE to PPE if the correct item is selected
    public void ChangeOptionsHH()
    {
        
        if (ChoicesInt == 0)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 25)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 33)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsN95()
    {
        if (ChoicesInt == 1)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 28)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsHC()
    {
        if (ChoicesInt == 6)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 27)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsEP()
    {
        if (ChoicesInt == 7)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 26)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsSC()
    {
        if (ChoicesInt == 8)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 15)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsGown()
    {
        if (ChoicesInt == 9)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 16)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsHH2()
    {
        if (ChoicesInt == 11)
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsGloves()
    {
        if (ChoicesInt == 12)
        {
            ChoicesInt += 1;
        }

        if (ChoicesInt == 20)
        {
            ChoicesInt += 1;
        }
    }

    //Goes back one question
    public void Undo()
    {
        ChoicesInt -= 1;
    }

    //Resets the questions to the beginning
    public void Reset()
    {
       
        ChoicesInt = 0;
    }


    //Exit Game
    public void ExitGame()
    {
        Application.Quit();
    }
}
