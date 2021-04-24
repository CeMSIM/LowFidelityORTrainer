using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroScreenManager : MonoBehaviour
{
    public GameObject Tutorial_Track;
    public GameObject Exam_Track;

    public GameObject IntroScreen;
    public GameObject Manager;


    public UIManager UI;
    void Start()
    {
        UI = Manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.stop == 1)
        {
            UI.AnswerCheck.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }

    }

    public void ActivateTutorial()
    {
        Tutorial_Track.gameObject.SetActive(true);
        IntroScreen.gameObject.SetActive(false);
        Exam_Track.gameObject.SetActive(false);
        
        
    }

    public void ActivateExam()
    {
        
        IntroScreen.gameObject.SetActive(false);
        
        //Tutorial_Track.gameObject.SetActive(false);
        UI.stop = 1;
    }
}
