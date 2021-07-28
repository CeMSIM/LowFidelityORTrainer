using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonRandomizer : MonoBehaviour
{
    public GameObject AnswerAButton;
    public GameObject AnswerBButton;
    public GameObject AnswerCButton;
    public GameObject AnswerDButton;

    private Vector3 OptionA;
    private Vector3 OptionB;
    private Vector3 OptionC;
    private Vector3 OptionD;

    public List<Vector3> OptionsList;

    public int x;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(AnswerAButton.transform.position);
        Debug.Log(AnswerBButton.transform.position);
        Debug.Log(AnswerCButton.transform.position);
        Debug.Log(AnswerDButton.transform.position);



        OptionA = new Vector3(-202.5f, 128, 0);
        OptionB = new Vector3(121.5f, 128, 0);
        OptionC = new Vector3(121.5f, 3, 0);
        OptionD = new Vector3(-202.5f, 3, 0);

        
        OptionsList.Add(OptionA);
        OptionsList.Add(OptionB);
        OptionsList.Add(OptionC);
        OptionsList.Add(OptionD);

    }

    // Update is called once per frame
    void Update()
    {
        
        //AnswerBButton.GetComponentInChildren<Transform>().position = OptionA;
    }

    public void RandomButtonPosition()
    {
        for (int i = 0; i < 4; i++)
        {
            int x = Random.Range(0, OptionsList.Count);
            if (i == 0)
            {
                AnswerAButton.transform.position = OptionsList[x];
            }
            else if (i == 1)
            {
                AnswerBButton.transform.position = OptionsList[x];
            }
            else if (i ==2)
            {
                AnswerCButton.transform.position = OptionsList[x];
            }
            else if (i == 3)
            {
                AnswerDButton.transform.position = OptionsList[x];
            }
            OptionsList.Remove(OptionsList[x]);
        }
        OptionsList.Add(OptionA);
        OptionsList.Add(OptionB);
        OptionsList.Add(OptionC);
        OptionsList.Add(OptionD);
    }
    

    

}
