using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour
{
    private List<string> Answers;
    public GameObject QuestText;
    public GameObject IntroCanvas;
    public GameObject Test;
    public GameObject Tutorial;
    public GameObject TutorialText;
    // Start is called before the first frame update
    void Start()
    {
        TutorialText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void MaskInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "Pick the first step in applying the Mask";
    }

    public void GlovesInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "How many gloves should be applied?";
    }

    public void GownInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "Pick the first step in applying the gown";
    }

    public void HandHygeineInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "Continue";
    }


    // Doffing Functions

    public void N95RInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "Pick the first step in removing the N95 Respirator";
    }

    public void HandHygeineRInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "Make sure you wash and sanitize thoroughly. PPE removal is complete, you may now exit the simulator.";
    }

    public void GownRInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "What is the first step in removing the gown?";
    }

    public void GlovesRInstructions()
    {
        QuestText.GetComponentInParent<Text>().text = "What is the first step in removing the gloves?";
    }

    public void GameModeSelect()
    {
        IntroCanvas.gameObject.SetActive(false);
    }

    public void TurnOffTestPath()
    {
        Test.gameObject.SetActive(false);
        QuestText.gameObject.SetActive(false);
        TutorialText.gameObject.SetActive(true);
    }

    public void TurnOffTutorialPath()
    {
        Tutorial.gameObject.SetActive(false);
    }
}
