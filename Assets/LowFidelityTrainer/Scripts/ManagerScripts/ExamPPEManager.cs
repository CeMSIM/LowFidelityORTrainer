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
    private RSIManager RSIM;

    public bool Doffing;
    public bool ButtonActive;

    public bool N95Bool;
    public bool GownBool;
    public bool GlovesBool;
    public bool EPBool;
    public bool HCBool;
    public bool SCBool;
    public bool HHBool;

    public List<string> DonningChoices;
    public List<string> DoffingChoices;

    public List<GameObject> ChecklistObjects;

    public Button N95Button;
    public Button HCButton;
    public Button SCButton;
    public Button EPButton;
    public Button GlovesButton;
    public Button GownButton;
    public Button HHButton;

    public GameObject BeginDoff;
    public GameObject EndDonning;
    public GameObject EndDoff;

    public bool EndDonningBool;
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
        HHBool = true;

        EndDonningBool = false;

        Doffing = false;


        UI = Managers.GetComponent<UIManager>();
        EUI = ExamManagers.GetComponent<ExamUIManager>();
        CLM = ChecklistManager.GetComponent<ChecklistManager>();
        RSIM = Managers.GetComponent<RSIManager>();
    }



    // Update is called once per frame
    void Update()
    {



        if (UI.AnswerButtons.activeSelf)
        {
            ButtonActive = true;
            //BeginDoff.gameObject.SetActive(false);
            //EndDonning.gameObject.SetActive(false);
            //EndDoff.gameObject.SetActive(false);
           
            
        }
        else
        {
            ButtonActive = false;
        }





        if (ButtonActive == false && HHBool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            HHButton.interactable = true;
        }
        else
        {
            HHButton.interactable = false;
        }




        if (ButtonActive == false && N95Bool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            N95Button.interactable = true;
        }
        else
        {
            N95Button.interactable = false;
        }


       
        


        if (ButtonActive == false && HCBool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            HCButton.interactable = true;
        }
        else
        {
            HCButton.interactable = false;
        }



        if (ButtonActive == false && SCBool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            SCButton.interactable = true;
        }
        else
        {
            SCButton.interactable = false;
        }



        if (ButtonActive == false && EPBool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            EPButton.interactable = true;
        }
        else
        {
            EPButton.interactable = false;
        }




        if (ButtonActive == false && GownBool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            GownButton.interactable = true;
        }
        else
        {
            GownButton.interactable = false;
        }



        if (ButtonActive == false && GlovesBool == true && RSIM.IQBool == false && RSIM.SGABool == false)
        {
            GlovesButton.interactable = true;
        }
        else
        {
            GlovesButton.interactable = false;
        }
    }

    public void HandHygieneOn()
    {
        HHBool = true;
    }

    public void HandHygieneOff()
    {
        HHBool = false;
    }
    public void StartDoffing()
    {
        Doffing = true;
        UI.BeginDoffBool = false;
        UI.DonningCheck.gameObject.SetActive(false);
        UI.DoffingCheck.gameObject.SetActive(true);
        N95Bool = true;
        GownBool = true;
        GlovesBool = true;
        EPBool = true;
        HCBool = true;
        SCBool = true;

        RSIM.IQBool = false;
        RSIM.SGABool = false;
        CLM.ChecklistTextPosition = 125;
        CLM.HHCount = 0;

        BeginDoff.gameObject.SetActive(false);

        foreach (var obj in ChecklistObjects)
        {
            Destroy(obj);
        }
        
    }

    public void EndDon()
    {
        EndDonning.gameObject.SetActive(false);

        N95Bool = false;
        GownBool = false;
        GlovesBool = false;
        EPBool = false;
        HCBool = false;
        SCBool = false;

        ButtonActive = true;
    }

    public void EndDoffing()
    {
        UI.FinalBG.gameObject.SetActive(true);
        CLM.ChecklistComparison.SetActive(true);
        if (RSIM.IQFinalBool == true)
        {
            RSIM.IntubationBG.gameObject.SetActive(true);
        }
        else if (RSIM.SGAFinalBool == true)
        {
            RSIM.SGABG.gameObject.SetActive(true);
        }
        
        
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
