using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChecklistManager : MonoBehaviour
{
    public GameObject ChecklistText;
    public GameObject FinalCheckText;
    public GameObject FinalCheckBG;


    public GameObject Managers;
    public GameObject ExamManagers;

    private UIManager UI;
    private ExamUIManager EUI;
    private ExamPPEManager EPP;

    public int ChecklistTextPosition;
    public int ChecklistTextSpacing;
    public int FinalCheckPosition;
    public int FinalCheckPositionX;
    public int FinalCheckSpacing;
    public int HHCount;

    public string RoomStatus;
    public GameObject RoomStatusText;

    public GameObject ChecklistComparison;

    public List<GameObject> FinalChecklist;
    // Start is called before the first frame update
    void Start()
    {
        RoomStatus = "Patient Room";
        UI = Managers.GetComponent<UIManager>();
        EUI = ExamManagers.GetComponent<ExamUIManager>();
        EPP = ExamManagers.GetComponent<ExamPPEManager>();

        ChecklistTextPosition = 125;
        ChecklistTextSpacing = 25;
        FinalCheckPosition = 650;
        FinalCheckSpacing = 75;
        FinalCheckPositionX = 300;
        HHCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RoomStatusText.GetComponentInChildren<TextMeshProUGUI>().text = RoomStatus;

        if (UI.stop == 0 && UI.ChoicesInt > 24)
        {
            RoomStatus = "Anteroom";
        }

        

     }

    public void ContinueFromChecklist()
    {
        ChecklistComparison.gameObject.SetActive(false);
    }


    public void MoveToAnteroom()
    {
        RoomStatus = "Anteroom";
    }

    public void ResetRoom()
    {
        RoomStatus = "Patient Room";
    }
    public void N95GenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "N95 Doffed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "N95 Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "N95 Donned";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "N95 Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);
            GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);

            ChecklistTextPosition -= ChecklistTextSpacing;
            FinalCheckPosition -= FinalCheckSpacing;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
            FinalChecklist.Add(ChecklistCheckPrefab);
        }

    }


    public void HCGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Head Cover Doffed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Head Cover Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Head Cover Donned";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Head Cover Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);
            GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);

            ChecklistTextPosition -= ChecklistTextSpacing;
            FinalCheckPosition -= FinalCheckSpacing;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
            FinalChecklist.Add(ChecklistCheckPrefab);
        }

    }


    public void SCGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Shoe Covers Doffed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Shoe Covers Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Shoe Covers Donned";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Shoe Covers Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);
            GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);

            ChecklistTextPosition -= ChecklistTextSpacing;
            FinalCheckPosition -= FinalCheckSpacing;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
            FinalChecklist.Add(ChecklistCheckPrefab);
        }
        
    }


    public void EPGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Eye Protection Doffed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Eye Protection Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Eye Protection Donned";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Eye Protection Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);
            GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);

            ChecklistTextPosition -= ChecklistTextSpacing;
            FinalCheckPosition -= FinalCheckSpacing;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
            FinalChecklist.Add(ChecklistCheckPrefab);
        }

    }


    public void GlovesGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gloves Doffed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Gloves Doffed";
            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gloves Donned";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Gloves Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);
            GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);

            ChecklistTextPosition -= ChecklistTextSpacing;
            FinalCheckPosition -= FinalCheckSpacing;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
            FinalChecklist.Add(ChecklistCheckPrefab);
        }

    }


    public void GownGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (EPP.Doffing == true)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gown Doffed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Gown Doffed";

            }
            else
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Gown Donned";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Gown Donned";
            }

            GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);
            GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);

            ChecklistTextPosition -= ChecklistTextSpacing;
            FinalCheckPosition -= FinalCheckSpacing;
            EPP.ChecklistObjects.Add(ChecklistPrefab);
            FinalChecklist.Add(ChecklistCheckPrefab);
        }

    }


    public void HHGenerateChecklist()
    {
        if (UI.stop != 0)
        {
            if (HHCount < 3)
            {
                ChecklistText.GetComponentInChildren<TextMeshProUGUI>().text = "Hands Washed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().text = "Hands Washed";
                FinalCheckText.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;

                GameObject ChecklistCheckPrefab = GameObject.Instantiate(FinalCheckText, new Vector3(FinalCheckPositionX, FinalCheckPosition, 0), Quaternion.identity);
                GameObject ChecklistPrefab = GameObject.Instantiate(ChecklistText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("MainCanvas").transform);

                
                ChecklistTextPosition -= ChecklistTextSpacing;
                FinalCheckPosition -= FinalCheckSpacing;
                EPP.ChecklistObjects.Add(ChecklistPrefab);
                FinalChecklist.Add(ChecklistCheckPrefab);
                HHCount += 1;
            }
        }

    }

    public void CreateFinalChecklist()
    {
        //FinalCheckText.transform.SetParent(FinalCheckBG.transform);
        //Instantiate(FinalCheckText, new Vector3(-440F, ChecklistTextPosition, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("ResultsCanvas").transform);
        foreach(var obj in FinalChecklist)
        {
            obj.transform.SetParent(FinalCheckBG.transform);
            Instantiate(obj, new Vector3(0, ChecklistTextPosition, 0), Quaternion.identity);
        }

        FinalChecklist.Clear();
        FinalCheckPositionX = 1300;
        FinalCheckPosition = 650;
    }
}
