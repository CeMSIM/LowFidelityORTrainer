using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FinalScreenManager : MonoBehaviour
{
    public GameObject WrongQuestion;
    public Canvas FinalCanvas;
    public int x;
    public int z;
    public GameObject QuestText;
    public GameObject AnswerCheckText;
    public int yVector;
    public GameObject Test;

    public GameObject AnswerAText;
    public GameObject AnswerBText;
    public GameObject AnswerCText;
    public GameObject AnswerDText;

    public GameObject Managers;
    private UIManager UI;

    public GameObject[] OptionsA;
    public GameObject[] OptionsB;
    public GameObject[] OptionsC;
    public GameObject[] OptionsD;
    
    // Start is called before the first frame update
    void Start()
    {
        //Integer used to identif if an answer is incorrect
        z = 0;
        //Accessing the UIManager script
        UI = Managers.GetComponent<UIManager>();
        


    }

    // Update is called once per frame
    void Update()
    {


 
    }





    //Checking the answers picked and changing the corresponding final screen text to red if wrong

    public void FinalCheckA()
    { 


        for (int i = 0; i < UI.AnswersArrayA.Length; i++)
        {
            if (AnswerAText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayA[i])
            {
                z += 1;
            }
            if (z == UI.AnswersArrayA.Length)
            {
                for (int j = 0; j < OptionsA.Length; j++)
                {
                    if (OptionsA[j].GetComponentInChildren<TextMeshProUGUI>().text == AnswerAText.GetComponentInParent<TextMeshProUGUI>().text)
                    {
                        OptionsA[j].GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
                    }
                }
            }
        }
        z = 0;
    }



    public void FinalCheckB()
    {
       

        for (int i = 0; i < UI.AnswersArrayB.Length; i++)
        {
            if (AnswerBText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayB[i])
            {
                z += 1;
            }
            if (z == UI.AnswersArrayB.Length)
            {
                for (int j = 0; j < OptionsB.Length; j++)
                {
                    if (OptionsB[j].GetComponentInChildren<TextMeshProUGUI>().text == AnswerBText.GetComponentInParent<TextMeshProUGUI>().text)
                    {
                        OptionsB[j].GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
                    }
                }
            }
        }
        z = 0;
    }
    public void FinalCheckC()
    {
        

        
        for (int i = 0; i < 6; i++)
        {
            if (AnswerCText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayC[i])
            {
                z += 1;
            }
            if (z == UI.AnswersArrayC.Length)
            {
                for (int j = 0; j < OptionsC.Length; j++)
                {
                    if (OptionsC[j].GetComponentInChildren<TextMeshProUGUI>().text == AnswerCText.GetComponentInParent<TextMeshProUGUI>().text)
                    {
                        OptionsC[j].GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
                    }
                }
            }
        }
        z = 0;
    }



    public void FinalCheckD()
    {
 

        for (int i = 0; i < UI.AnswersArrayD.Length; i++)
        {
            if (AnswerDText.GetComponentInParent<TextMeshProUGUI>().text != UI.AnswersArrayD[i])
            {
                z += 1;
            }
            if (z == UI.AnswersArrayD.Length)
            {
                for (int j = 0; j < OptionsD.Length; j++)
                {
                    if (OptionsD[j].GetComponentInChildren<TextMeshProUGUI>().text == AnswerDText.GetComponentInParent<TextMeshProUGUI>().text)
                    {
                        OptionsD[j].GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
                    }
                }
            }
        }
        z = 0;
    }

}
