using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class FinalScreenManager : MonoBehaviour
{


    public GameObject TitleScreen;
    public Canvas FinalCanvas;
    //integers used to reset for loops
    public int x;
    public int z;

    
    public GameObject QuestText;
    public GameObject AnswerCheckText;
    public int yVector;
    public GameObject Test;

    //Accessing the question texts
    public GameObject AnswerAText;
    public GameObject AnswerBText;
    public GameObject AnswerCText;
    public GameObject AnswerDText;

    public GameObject Managers;
    private UIManager UI;

    //Answer choice arrays
    public GameObject[] OptionsA;
    public GameObject[] OptionsB;
    public GameObject[] OptionsC;
    public GameObject[] OptionsD;

    //Separate Final Review Screens
    public GameObject N95Don;
    public GameObject GownDon;
    public GameObject GlovesDon;
    public GameObject N95Doff;
    public GameObject GownDoff;
    public GameObject GlovesDoff;

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

    //Creating functions that allow the player to see each final review screen
    public void ViewN95Don()
    {
        N95Don.gameObject.SetActive(true);
    }

    public void ViewGownDon()
    {
        GownDon.gameObject.SetActive(true);
    }

    public void ViewGlovesDon()
    {
        GlovesDon.gameObject.SetActive(true);
    }

    public void ViewN95Doff()
    {
        N95Doff.gameObject.SetActive(true);
    }

    public void ViewGownDoff()
    {
        GownDoff.gameObject.SetActive(true);
    }

    public void ViewGlovesDoff()
    {
        GlovesDoff.gameObject.SetActive(true);
    }



    //Function to turn off the individual review screens whenthe player returns to the main final screen

    public void ReturnToMain()
    {
        N95Don.gameObject.SetActive(false);
        GownDon.gameObject.SetActive(false);
        GlovesDon.gameObject.SetActive(false);
        N95Doff.gameObject.SetActive(false);
        GownDoff.gameObject.SetActive(false);
        GlovesDoff.gameObject.SetActive(false);
    }

    public void ReturnToTitle()
    {
        
        SceneManager.LoadScene("1_QuizScene");
        TitleScreen.gameObject.SetActive(true);
    }

}
