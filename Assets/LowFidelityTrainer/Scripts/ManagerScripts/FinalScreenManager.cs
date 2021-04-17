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
        z = 0;
        UI = Managers.GetComponent<UIManager>();
        yVector = 600;
       // Debug.Log(GameObject.FindGameObjectWithTag("ResultsCanvas"));
        //GameObject x12 =  GameObject.Instantiate(WrongQuestion, new Vector3(0, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("ResultsCanvas").transform);

        //  GameObject y = GameObject.FindGameObjectWithTag("ResultsCanvas");
        Debug.Log(QuestText.GetComponentInParent<TextMeshProUGUI>().text);
        

    }

    // Update is called once per frame
    void Update()
    {


 
    }

    public void SpawnWrongQuestion()
    {
        
        if (AnswerCheckText.GetComponent<TextMeshProUGUI>().text == "Wrong")
        {
            for (int i = 0; i < 1; i++)
            {
               // Debug.Log(QuestText.GetComponentInParent<TextMeshProUGUI>().text);
                WrongQuestion.GetComponentInChildren<TextMeshProUGUI>().text = QuestText.GetComponentInParent<TextMeshProUGUI>().text;
                GameObject.Instantiate(WrongQuestion, new Vector3(850, yVector, 0), Quaternion.identity, FinalCanvas.transform);

            }
            yVector -= 75;
            x += 1;
        }
    }





    public void FinalCheckA()
    {
        Debug.Log(OptionsA[0].GetComponentInChildren<TextMeshProUGUI>().text);
        // Debug.Log(AnswerCText.GetComponentInParent<TextMeshProUGUI>().text);
        // Debug.Log(UI.AnswersArrayC[1]);

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
        //Debug.Log(OptionsA[0].GetComponentInChildren<TextMeshProUGUI>().text);
        // Debug.Log(AnswerCText.GetComponentInParent<TextMeshProUGUI>().text);
        // Debug.Log(UI.AnswersArrayC[1]);

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
        Debug.Log(OptionsC[0].GetComponentInChildren<TextMeshProUGUI>().text);
       // Debug.Log(AnswerCText.GetComponentInParent<TextMeshProUGUI>().text);
       // Debug.Log(UI.AnswersArrayC[1]);
        
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
        //Debug.Log(OptionsD[0].GetComponentInChildren<TextMeshProUGUI>().text);
        // Debug.Log(AnswerCText.GetComponentInParent<TextMeshProUGUI>().text);
        // Debug.Log(UI.AnswersArrayC[1]);

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
