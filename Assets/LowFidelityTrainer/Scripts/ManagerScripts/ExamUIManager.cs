using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class ExamUIManager : MonoBehaviour
{
    public int ExamChoicesInt;

    private UIManager UI;
    
    public GameObject Managers;

    private QuestionsManager[] TextInfo;

    public GameObject AnswerAText;
    public GameObject AnswerBText;
    public GameObject AnswerCText;
    public GameObject AnswerDText;
    public GameObject QuestionInfoTextObject;
    public GameObject QuestText;

    public QuestionsManager test;
    // Start is called before the first frame update
    void Start()
    {
        
        //TextInfo = new QuestionsManager[35];
        UI = Managers.GetComponent<UIManager>();
        //l = Managers.GetComponent<UIElements>();
        
        ExamChoicesInt = 0;


        
        
  

        
        Debug.Log(AnswerAText.GetComponentInParent<TextMeshProUGUI>().text);
        
        //Debug.Log(l.QuestionInfoTextObject.text = TextInfo[4].Info);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(UI.TextInfo[ExamChoicesInt].Info);

        QuestionInfoTextObject.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].Info;
        AnswerAText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerA;
        AnswerBText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerB;
        AnswerCText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerC;
        AnswerDText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].AnswerD;
        QuestText.GetComponentInChildren<TextMeshProUGUI>().text = UI.TextInfo[ExamChoicesInt].QuestText;

    }

    public void ChangeExamOptions()
    {
        ExamChoicesInt += 1;
    }
}
