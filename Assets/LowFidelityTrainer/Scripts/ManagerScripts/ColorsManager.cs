using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorsManager : MonoBehaviour
{
    private UIManager UI;
    private ExamUIManager EUI;

    public GameObject ExamManager;
    public GameObject Manage;


    public GameObject HHButtonText;
    public GameObject EPButtonText;
    public GameObject N95ButtonText;
    public GameObject HCButtonText;
    public GameObject SCButtonText;
    public GameObject GlovesButtonText;
    public GameObject GownButtonText;


    [SerializeField] private Material HHMaterial;
    [SerializeField] private Material EPMaterial;
    [SerializeField] private Material N95Material;
    [SerializeField] private Material HCMaterial;
    [SerializeField] private Material SCMaterial;
    [SerializeField] private Material GlovesMaterial;
    [SerializeField] private Material GownMaterial;
    // Start is called before the first frame update
    void Start()
    {
        HHMaterial.color = Color.white;
        EPMaterial.color = Color.white;
        N95Material.color = Color.white;
        HCMaterial.color = Color.white;
        SCMaterial.color = Color.white;
        GlovesMaterial.color = Color.white;
        GownMaterial.color = Color.white;

        
        EUI = ExamManager.GetComponent<ExamUIManager>();
        UI = Manage.GetComponent<UIManager>();

        HHButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
        EPButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.green;
        N95ButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
        HCButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.gray;
        SCButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.cyan;
        GlovesButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.blue;
        GownButtonText.GetComponentInChildren<TextMeshProUGUI>().color = Color.magenta;
    }

    // Update is called once per frame
    void Update()
    {
        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "Hand Hygiene")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
        }


        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "Shoe Covers")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.cyan;
        }

        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "Gown")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.magenta;
        }

        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "Head Cover")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.gray;
        }

        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "Gloves")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.blue;
        }

        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "Eye Protection")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.green;
        }


        if (EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().text == "N95 Respirator")
        {
            EUI.CurrentPPE.GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
        }





        if (UI.ChoicesInt > 5 && UI.ChoicesInt < 33)
        {
            N95Material.color = Color.green;
        }
        else
        {
            N95Material.color = Color.white;
        }



        if (UI.ChoicesInt > 6 && UI.ChoicesInt < 28)
        {
            HCMaterial.color = Color.green;
        }
        else
        {
            HCMaterial.color = Color.white;
        }


        if (UI.ChoicesInt > 7 && UI.ChoicesInt < 27)
        {
            EPMaterial.color = Color.green;
        }
        else
        {
            EPMaterial.color = Color.white;
        }



        if (UI.ChoicesInt > 8 && UI.ChoicesInt < 16)
        {
            SCMaterial.color = Color.green;
        }
        else
        {
            SCMaterial.color = Color.white;
        }



        if (UI.ChoicesInt > 10 && UI.ChoicesInt < 20)
        {
            GownMaterial.color = Color.green;
        }
        else
        {
            GownMaterial.color = Color.white;
        }



        if (UI.ChoicesInt > 14 && UI.ChoicesInt < 25)
        {
            GlovesMaterial.color = Color.green;
        }
        else
        {
            GlovesMaterial.color = Color.white;
        }
    }

    
}
