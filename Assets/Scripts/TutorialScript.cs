using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject TutorialQuestText;
    public GameObject Exam;
    public GameObject OptionA;
    public GameObject OptionB;
    public GameObject OptionC;
    public GameObject OptionD;
    public GameObject Exit;

    public GameObject AnswerCheck;

    public string[] AnswersA;
    public string[] AnswersB;
    public string[] AnswersC;
    public string[] AnswersD;

    public string[] ChoicesA;
    public string[] ChoicesB;
    public string[] ChoicesC;
    public string[] ChoicesD;

    public string[] TutorialText;

    public int x;
    private int y;
    public int ChangeTutorialText;

    public GameObject HH1Checklist;
    public GameObject N95ONCheck;
    public GameObject DHCONCheck;
    public GameObject EPONCheck;
    public GameObject SCONCheck;
    public GameObject GownONCheck;
    public GameObject GlovesONCheck;
    public GameObject SCOFFCheck;
    public GameObject GownOFFCheck;
    public GameObject GlovesOFFCheck;
    public GameObject Outside;
    public GameObject EPOFFCheck;
    public GameObject HCOFFCheck;
    public GameObject N95OFFCheck;
    public GameObject HH2Checklist;
    public GameObject HH3Checklist;
    // Start is called before the first frame update
    void Start()
    {
        HH1Checklist.gameObject.SetActive(false);
        N95ONCheck.gameObject.SetActive(false);
        DHCONCheck.gameObject.SetActive(false);
        EPONCheck.gameObject.SetActive(false);
        SCONCheck.gameObject.SetActive(false);
        GownONCheck.gameObject.SetActive(false);
        GlovesONCheck.gameObject.SetActive(false);
        Outside.gameObject.SetActive(false);
        SCOFFCheck.gameObject.SetActive(false);
        EPOFFCheck.gameObject.SetActive(false);
        HCOFFCheck.gameObject.SetActive(false);
        N95OFFCheck.gameObject.SetActive(false);
        HH2Checklist.gameObject.SetActive(false);
        HH3Checklist.gameObject.SetActive(false);

        ChangeTutorialText = 0;
        y = 0;
        x = 0;
        OptionA.gameObject.SetActive(false);
        OptionB.gameObject.SetActive(false);
        OptionC.gameObject.SetActive(false);
        OptionD.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (OptionC.GetComponentInChildren<Text>().text == "" )
        {
            
            x += 1;
            OptionA.gameObject.SetActive(false);
            OptionB.gameObject.SetActive(false);
            OptionC.gameObject.SetActive(false);
            OptionD.gameObject.SetActive(false);
            Exit.gameObject.SetActive(false);
        }
        if (x < 26)
        {
            OptionA.GetComponentInChildren<Text>().text = ChoicesA[x];
            OptionB.GetComponentInChildren<Text>().text = ChoicesB[x];
            OptionC.GetComponentInChildren<Text>().text = ChoicesC[x];
            OptionD.GetComponentInChildren<Text>().text = ChoicesD[x];
        }


        TutorialQuestText.GetComponentInChildren<Text>().text = TutorialText[ChangeTutorialText];

        if (ChangeTutorialText >= 1)
        {
            HH1Checklist.gameObject.SetActive(true);
        }
        else
        {
            HH1Checklist.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 6)
        {
            N95ONCheck.gameObject.SetActive(true);
        }
        else
        {
            N95ONCheck.gameObject.SetActive(false);
        }



        if (ChangeTutorialText >= 7)
        {
            DHCONCheck.gameObject.SetActive(true);
        }
        else
        {
            DHCONCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 8)
        {
            EPONCheck.gameObject.SetActive(true);
        }
        else
        {
            EPONCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 9)
        {
            SCONCheck.gameObject.SetActive(true);
        }
        else
        {
            SCONCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 11)
        {
            GownONCheck.gameObject.SetActive(true);
        }
        else
        {
            GownONCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 12)
        {
           HH3Checklist.gameObject.SetActive(true);
        }
        else
        {
            HH3Checklist.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 15)
        {
            GlovesONCheck.gameObject.SetActive(true);
        }
        else
        {
            GlovesONCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 16)
        {
            SCOFFCheck.gameObject.SetActive(true);
        }
        else
        {
            SCOFFCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 21)
        {
            GownOFFCheck.gameObject.SetActive(true);
        }
        else
        {
            GownOFFCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 26)
        {
            GlovesOFFCheck.gameObject.SetActive(true);
        }
        else
        {
            GlovesOFFCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 26)
        {
            Outside.gameObject.SetActive(true);
        }
        else
        {
            Outside.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 27)
        {
            HH2Checklist.SetActive(true);
        }
        else
        {
            HH2Checklist.SetActive(false);
        }


        if (ChangeTutorialText >= 28)
        {
            EPOFFCheck.gameObject.SetActive(true);
        }
        else
        {
            EPOFFCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 29)
        {
            HCOFFCheck.gameObject.SetActive(true);
        }
        else
        {
            HCOFFCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 34)
        {
            N95OFFCheck.gameObject.SetActive(true);
        }
        else
        {
            N95OFFCheck.gameObject.SetActive(false);
        }

        if (ChangeTutorialText >= 35)
        {
            HH3Checklist.gameObject.SetActive(true);
        }
    }


    public void CheckAnswerA()
    {
        for (int i = 0; i < 5; i++)
        {
            if (OptionA.GetComponentInChildren<Text>().text == AnswersA[i].ToString())
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Correct Answer";
                x += 1;
                y += 1;
                ChangeTutorialText += 1;
            }
            if ( y < 1)
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Wrong Answer";
            }
            OptionA.GetComponentInChildren<Text>().text = ChoicesA[x];
            OptionB.GetComponentInChildren<Text>().text = ChoicesB[x];
            OptionC.GetComponentInChildren<Text>().text = ChoicesC[x];
            OptionD.GetComponentInChildren<Text>().text = ChoicesD[x];
            
        }

        y = 0;


    }

    public void CheckAnswerB()
    {
        for (int i = 0; i < 6; i++)
        {
            if (OptionB.GetComponentInChildren<Text>().text == AnswersB[i].ToString())
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Correct Answer";
                x += 1;
                y += 1;
                ChangeTutorialText += 1;
            }

            if ( y < 1)
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Wrong Answer";
            }
            OptionA.GetComponentInChildren<Text>().text = ChoicesA[x];
            OptionB.GetComponentInChildren<Text>().text = ChoicesB[x];
            OptionC.GetComponentInChildren<Text>().text = ChoicesC[x];
            OptionD.GetComponentInChildren<Text>().text = ChoicesD[x];
        }
        y = 0;
    }

    public void CheckAnswerC()
    {
        for (int i = 0; i < 6; i++)
        {
            if (OptionC.GetComponentInChildren<Text>().text == AnswersC[i].ToString())
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Correct Answer";
                x += 1;
                y += 1;
                ChangeTutorialText += 1;
            }

            if (y < 1)
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Wrong Answer";
            }
            OptionA.GetComponentInChildren<Text>().text = ChoicesA[x];
            OptionB.GetComponentInChildren<Text>().text = ChoicesB[x];
            OptionC.GetComponentInChildren<Text>().text = ChoicesC[x];
            OptionD.GetComponentInChildren<Text>().text = ChoicesD[x];
        }
        y = 0;


    }
    public void ExitButton()
    {
        OptionA.gameObject.SetActive(false);
        OptionB.gameObject.SetActive(false);
        OptionC.gameObject.SetActive(false);
        OptionD.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);
        TutorialQuestText.GetComponentInParent<Text>().text = "Select the next item of PPE";
    }
    public void CheckAnswerD()
    {
        for (int i = 0; i < 6; i++)
        {
            if (OptionD.GetComponentInChildren<Text>().text == AnswersD[i].ToString())
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Correct Answer";
                x += 1;
                y += 1;
                ChangeTutorialText += 1;
            }

            if (y < 1)
            {
                AnswerCheck.GetComponentInChildren<Text>().text = "Wrong Answer";
                
            }
            OptionA.GetComponentInChildren<Text>().text = ChoicesA[x];
            OptionB.GetComponentInChildren<Text>().text = ChoicesB[x];
            OptionC.GetComponentInChildren<Text>().text = ChoicesC[x];
            OptionD.GetComponentInChildren<Text>().text = ChoicesD[x];
        }
        y = 0;

    }
    public void ActivateButtons()
    {
        OptionA.gameObject.SetActive(true);
        OptionB.gameObject.SetActive(true);
        OptionC.gameObject.SetActive(true);
        OptionD.gameObject.SetActive(true);
        Exit.gameObject.SetActive(true);
    }

    public void ChangeTTT()
    {
        ChangeTutorialText += 1;
    }

    public void Undo()
    {
        ChangeTutorialText -= 1;
    }

}
