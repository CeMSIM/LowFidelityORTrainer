
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.IO;
using UnityEngine.EventSystems;

[Serializable()]
public struct UIManagerParameters
{
    [Header("Answers Options")]
    [SerializeField] float margins;
    public float Margins { get { return margins; } }
}

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
}

public class UIManager : MonoBehaviour
{
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
    private QuestionsManager[] TextInfo;
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



    private void Start()
    {
        EPDonCheck.gameObject.SetActive(false);
        ChoicesInt = 0;
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


    }

    private void Update()
    {
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
        }

        else
        {
            GlovesDonCheck.gameObject.SetActive(false);
        }


        if (uIElements.AnswerAInfoTextObject.text == "")
        {
            AnswerButtons.gameObject.SetActive(false);
        }
       else
        {
            AnswerButtons.gameObject.SetActive(true);
        }

        if (ChoicesInt > 15)
        {
            SCDoffCheck.gameObject.SetActive(true);
        }

        else
        {
            SCDoffCheck.gameObject.SetActive(false);
        }



        uIElements.QuestionInfoTextObject.text = TextInfo[ChoicesInt].Info;
        uIElements.AnswerAInfoTextObject.text = TextInfo[ChoicesInt].AnswerA;
        uIElements.AnswerBInfoTextObject.text = TextInfo[ChoicesInt].AnswerB;
        uIElements.AnswerCInfoTextObject.text = TextInfo[ChoicesInt].AnswerC;
        uIElements.AnswerDInfoTextObject.text = TextInfo[ChoicesInt].AnswerD;
        uIElements.QuestTextObject.text = TextInfo[ChoicesInt].QuestText;
    }

    public void ChangeOptionsA()
    {
        for (int i = 0; i < AnswersArrayA.Length; i++)
        {
            if (uIElements.AnswerAInfoTextObject.text == AnswersArrayA[i])
            {
                ChoicesInt += 1;
            }
        }
        
       
    }

    public void ChangeOptionsB()
    {
        for (int i = 0; i < AnswersArrayB.Length; i++)
        {
            if (uIElements.AnswerBInfoTextObject.text == AnswersArrayB[i])
            {
                ChoicesInt += 1;
            }
        }


    }

    public void ChangeOptionsC()
    {
        for (int i = 0; i < AnswersArrayC.Length; i++)
        {
            if (uIElements.AnswerCInfoTextObject.text == AnswersArrayC[i])
            {
                ChoicesInt += 1;
            }
        }


    }

    public void ChangeOptionsD()
    {
        for (int i = 0; i < AnswersArrayD.Length; i++)
        {
            if (uIElements.AnswerDInfoTextObject.text == AnswersArrayD[i])
            {
                ChoicesInt += 1;
            }
        }


    }


    public void ChangeOptionsHH()
    {
        if (uIElements.QuestTextObject.text == "Welcome to the Vortex Simulator! Please select the first step in PPE donning, Hand Hygeine")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Gloves properly doffed, move to an outside room and select Hand Hygeine to wash your hands")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "N95 Mask has been properly doffed, move onto Hand Hygiene")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsN95()
    {
        if (uIElements.QuestTextObject.text ==  "Select the first item of PPE to don, the N95 Mask")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Select the next item of PPE to doff, the N95 Mask")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsHC()
    {
        if (uIElements.QuestTextObject.text ==  "Select the next item of PPE donning, the Head Covers")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Select the next item of PPE to doff, the Head Covers")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsEP()
    {
        if (uIElements.QuestTextObject.text == "Please select the next item of PPE donning, the Eye Protection")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Select the next item of PPE to doff, the Goggles/Eye Protection")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsSC()
    {
        if (uIElements.QuestTextObject.text == "Select the next PPE item to don, the Shoes Covers")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Donning completed, now move onto the doffing sequence. Select the first item of PPE doffing, the shoe covers")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsGown()
    {
        if (uIElements.QuestTextObject.text == "Select the next item of PPE donning, the Gown")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Select the next item of PPE to doff, the Gown")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsHH2()
    {
        if (uIElements.QuestTextObject.text == "Select the  next item of PPE donning, Hand Hygeine")
        {
            ChoicesInt += 1;
        }
    }

    public void ChangeOptionsGloves()
    {
        if (uIElements.QuestTextObject.text ==  "Select the next item of PPE donning, the Gloves")
        {
            ChoicesInt += 1;
        }

        if (uIElements.QuestTextObject.text == "Gown properly doffed, select the next item of PPE to doff, the Gloves")
        {
            ChoicesInt += 1;
        }
    }

    public void Undo()
    {
        ChoicesInt -= 1;
    }

    public void Reset()
    {
        ChoicesInt = 0;
    }
}
