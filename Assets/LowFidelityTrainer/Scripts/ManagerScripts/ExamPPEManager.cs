using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ExamPPEManager : MonoBehaviour
{
    public GameObject Managers;
    public GameObject ExamManagers;
    public GameObject ChecklistManager;

    private UIManager UI;
    private ExamUIManager EUI;
    private ChecklistManager CLM;

    public bool Doffing;
    private bool ButtonActive;

    private bool N95Bool;
    private bool GownBool;
    private bool GlovesBool;
    private bool EPBool;
    private bool HCBool;
    private bool SCBool;

    public List<string> DonningChoices;
    public List<string> DoffingChoices;

    public List<GameObject> ChecklistObjects;

    public Button N95Button;
    public Button HCButton;
    public Button SCButton;
    public Button EPButton;
    public Button GlovesButton;
    public Button GownButton;

    public GameObject BeginDoff;
    // Start is called before the first frame update
    void Start()
    {
        N95Bool = true;
        HCBool = true;
        SCBool = true;
        EPBool = true;
        GlovesBool = true;
        GownBool = true;
        ButtonActive = true;

        Doffing = false;


        UI = Managers.GetComponent<UIManager>();
        EUI = ExamManagers.GetComponent<ExamUIManager>();
        CLM = ChecklistManager.GetComponent<ChecklistManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (UI.AnswerButtons.activeSelf)
        {
            ButtonActive = false;
        }
        else
        {
            ButtonActive = true;
        }

        if (ButtonActive == true && N95Bool == true)
        {
            N95Button.interactable = true;
        }
        else
        {
            N95Button.interactable = false;
        }


        if (ButtonActive == true && HCBool == true)
        {
            HCButton.interactable = true;
        }
        else
        {
            HCButton.interactable = false;
        }



        if (ButtonActive == true && SCBool == true)
        {
            SCButton.interactable = true;
        }
        else
        {
            SCButton.interactable = false;
        }



        if (ButtonActive == true && EPBool == true)
        {
            EPButton.interactable = true;
        }
        else
        {
            EPButton.interactable = false;
        }




        if (ButtonActive == true && GownBool == true)
        {
            GownButton.interactable = true;
        }
        else
        {
            GownButton.interactable = false;
        }



        if (ButtonActive == true && GlovesBool == true)
        {
            GlovesButton.interactable = true;
        }
        else
        {
            GlovesButton.interactable = false;
        }
    }

    public void StartDoffing()
    {
        Doffing = true;
        N95Button.interactable = true;
        UI.DonningCheck.gameObject.SetActive(false);
        UI.DoffingCheck.gameObject.SetActive(true);
        N95Bool = true;
        GownBool = true;
        GlovesBool = true;
        EPBool = true;
        HCBool = true;
        SCBool = true;

        CLM.ChecklistTextPosition = 125;
        CLM.HHCount = 0;

        BeginDoff.gameObject.SetActive(false);

        foreach (var obj in ChecklistObjects)
        {
            Destroy(obj);
        }
        
    }

    public void EndDoffing()
    {
        UI.BG.gameObject.SetActive(true);
    }


    public void HH()
    {
        if (UI.stop != 0 && Doffing == false && EUI.ExamChoicesInt == 0)
        {
            EUI.ExamChoicesInt = 1;
            DonningChoices.Add("Hand Hygiene");

        }
        else if (UI.stop != 0 && Doffing == false && EUI.ExamChoicesInt > 1)
        {
            EUI.ExamChoicesInt = 12;
            DonningChoices.Add("Hand Hygiene");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 26;
            DonningChoices.Add("Hand Hygiene");
        }
    }
    public void N95()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 2;
            DonningChoices.Add("N95");
            N95Bool = false;
            
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 29;
            DoffingChoices.Add("N95");
            N95Bool = false;
        }

    }

    public void Gloves()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 13;
            DonningChoices.Add("Gloves");
            GlovesBool = false;
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 21;
            DoffingChoices.Add("Gloves");
            GlovesBool = false;
        }
    }

    public void Gown()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 10;
            DonningChoices.Add("Gown");
            GownBool = false;
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 17;
            DoffingChoices.Add("Gown");
            GownBool = false;
        }
    }

    public void EyeProtection()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 8;
            DonningChoices.Add("Eye Protection");
            EPBool = false;
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 27;
            DoffingChoices.Add("Eye Protection");
            EPBool = false;
        }
    }

    public void HeadCover()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 7;
            DonningChoices.Add("Head Cover");
            HCBool = false;
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 28;
            DoffingChoices.Add("Head Cover");
            HCBool = false;
        }
    }

    public void ShoeCovers()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 9;
            DonningChoices.Add("Shoe Covers");
            SCBool = false;
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 16;
            DoffingChoices.Add("Shoe Covers");
            SCBool = false;
        }
    }


}
