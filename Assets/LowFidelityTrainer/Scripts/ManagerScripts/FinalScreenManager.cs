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
    public GameObject QuestText;
    public GameObject AnswerCheckText;
    public int yVector;
    // Start is called before the first frame update
    void Start()
    {
        yVector = 600;
        Debug.Log(GameObject.FindGameObjectWithTag("ResultsCanvas"));
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
                Debug.Log(QuestText.GetComponentInParent<TextMeshProUGUI>().text);
                WrongQuestion.GetComponentInChildren<TextMeshProUGUI>().text = QuestText.GetComponentInParent<TextMeshProUGUI>().text;
                GameObject.Instantiate(WrongQuestion, new Vector3(850, yVector, 0), Quaternion.identity, FinalCanvas.transform);

            }
            yVector -= 75;
            x += 1;
        }
    }




    
}
