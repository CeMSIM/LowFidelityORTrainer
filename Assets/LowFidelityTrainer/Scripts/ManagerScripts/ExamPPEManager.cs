using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ExamPPEManager : MonoBehaviour
{
    public GameObject Managers;
    public GameObject ExamManagers;

    private UIManager UI;
    private ExamUIManager EUI;

    private bool Doffing;

    public List<string> DonningChoices;
    public List<string> DoffingChoices;

    public Button N95Button;
    public Button HCButton;
    public Button SCButton;
    public Button EPButton;
    public Button GlovesButton;
    public Button GownButton;
    // Start is called before the first frame update
    void Start()
    {
        
        Doffing = false;


        UI = Managers.GetComponent<UIManager>();
        EUI = ExamManagers.GetComponent<ExamUIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.N95DonCheck.activeSelf && UI.DonningCheck.activeSelf)
        {
            N95Button.interactable = false;
        }
        else
        {
            N95Button.interactable = true;
        }



        if (UI.GlovesDonCheck.activeSelf && UI.DonningCheck.activeSelf)
        {
            GlovesButton.interactable = false;
        }
        else
        {
            GlovesButton.interactable = true;
        }



        if (UI.GownDonCheck.activeSelf && UI.DonningCheck.activeSelf)
        {
            GownButton.interactable = false;
        }
        else
        {
            GownButton.interactable = true;
        }



        if (UI.HCDonCheck.activeSelf && UI.DonningCheck.activeSelf)
        {
            HCButton.interactable = false;
        }
        else
        {
            HCButton.interactable = true;
        }



        if (UI.SCDonCheck.activeSelf && UI.DonningCheck.activeSelf)
        {
            SCButton.interactable = false;
        }
        else
        {
            SCButton.interactable = true;
        }



        if (UI.EPDonCheck.activeSelf && UI.DonningCheck.activeSelf)
        {
            EPButton.interactable = false;
        }
        else
        {
            EPButton.interactable = true;
        }
    }

    public void StartDoffing()
    {
        Doffing = true;
        N95Button.interactable = true;
        UI.DonningCheck.gameObject.SetActive(false);

    }
    public void N95()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 2;
            DonningChoices.Add("N95");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 29;
            DoffingChoices.Add("N95");
        }

    }

    public void Gloves()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 13;
            DonningChoices.Add("Gloves");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 21;
            DoffingChoices.Add("Gloves");
        }
    }

    public void Gown()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 10;
            DonningChoices.Add("Gown");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 29;
            DoffingChoices.Add("N95");
        }
    }

    public void EyeProtection()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 8;
            DonningChoices.Add("Eye Protection");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 27;
            DoffingChoices.Add("Eye Protection");
        }
    }

    public void HeadCover()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 7;
            DonningChoices.Add("Head Cover");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 28;
            DoffingChoices.Add("Head Cover");
        }
    }

    public void ShoeCovers()
    {
        if (UI.stop != 0 && Doffing == false)
        {
            EUI.ExamChoicesInt = 9;
            DonningChoices.Add("Shoe Covers");
        }
        else if (UI.stop != 0 && Doffing == true)
        {
            EUI.ExamChoicesInt = 16;
            DoffingChoices.Add("Shoe Covers");
        }
    }


}
