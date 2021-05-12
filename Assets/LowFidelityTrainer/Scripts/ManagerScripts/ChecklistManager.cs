using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChecklistManager : MonoBehaviour
{
    public GameObject ChecklistText;
    public GameObject Managers;
    public GameObject ExamManagers;

    private UIManager UI;
    private ExamUIManager EUI;
    private ExamPPEManager EPP;

    public int ChecklistTextPosition;
    public int HHCount;
    // Start is called before the first frame update
    void Start()
    {

        UI = Managers.GetComponent<UIManager>();
        EUI = ExamManagers.GetComponent<ExamUIManager>();
        EPP = ExamManagers.GetComponent<ExamPPEManager>();

        ChecklistTextPosition = 125;
        HHCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void N95GenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "N95 Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "N95 Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            ChecklistTextPosition -= 25;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
        }

    }


    public void HCGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Head Cover Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Head Cover Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            ChecklistTextPosition -= 25;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
        }

    }


    public void SCGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Shoe Covers Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Shoe Covers Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            ChecklistTextPosition -= 25;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
        }
        
    }


    public void EPGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Eye Protection Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Eye Protection Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            ChecklistTextPosition -= 25;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
        }

    }


    public void GlovesGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gloves Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gloves Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            ChecklistTextPosition -= 25;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
        }

    }


    public void GownGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gown Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gown Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

            ChecklistTextPosition -= 25;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
        }

    }


    public void HHGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (HHCount < 3)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Hands Washed";

                GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

                ChecklistTextPosition -= 25;
                EPP.ChecklistObjects.Add(ChecklistPrefab);
                HHCount += 1;
            }
        }

    }
}
