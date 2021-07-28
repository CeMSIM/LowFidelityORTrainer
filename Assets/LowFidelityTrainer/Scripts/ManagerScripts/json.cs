using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SerializeJson;
using System.IO;
using Newtonsoft.Json;




public class json : MonoBehaviour
{
    public GameObject Manager;

    private UIManager UI;
    private RSIManager RSI;

    
    private Dictionary<string, string> LocalizedText;
    // Start is called before the first frame update
    void Start()
    {

        UI = Manager.GetComponent<UIManager>();
        RSI = Manager.GetComponent<RSIManager>();
        //Question2 question1 = new Question2();
        QuestionsManager QM = new QuestionsManager();
        List<QuizQuestion> QQ = new List<QuizQuestion>();
        Question2[] Test2 = new Question2[16];
        Question2[] SGAQ = new Question2[10];
        Question2[] IQ = new Question2[13];
        Question2[] DoffingQ = new Question2[20]; 


        List<string> Test = new List<string>();
        for (int i = 0; i < 16; i++)
        {
            Question2 question1 = new Question2();
            QQ.Add(new QuizQuestion(UI.TextInfo[i].Info, UI.TextInfo[i].AnswerA, UI.TextInfo[i].AnswerB, UI.TextInfo[i].AnswerC, UI.TextInfo[i].AnswerD, UI.TextInfo[i].QuestText, UI.TextInfo[i].CurrentObject, UI.TextInfo[i].CurrentNumber));
            question1.QuestionsText = UI.TextInfo[i].Info;
            question1.OptionA = UI.TextInfo[i].AnswerA;
            question1.OptionB = UI.TextInfo[i].AnswerB;
            question1.OptionC = UI.TextInfo[i].AnswerC;
            question1.OptionD = UI.TextInfo[i].AnswerD;
            question1.QuestText = UI.TextInfo[i].QuestText;
            question1.CurrentObject = UI.TextInfo[i].CurrentObject;
            question1.CurrentNumber = UI.TextInfo[i].CurrentNumber;
            if (i == 1)
            {
                question1.item = "Hand Hygiene";
            }
            else if (i > 1 && i < 7)
            {
                question1.item = "N95 Mask";
            }
            else if (i == 7)
            {
                question1.item = "Head Cover";
            }
            else if (i == 8)
            {
                question1.item = "Eye Protection";
            }
            else if (i == 9)
            {
                question1.item = "Shoe Covers";
            }
            else if (i > 9 && i < 12)
            {
                question1.item = "Gown";
            }
            else if (i == 12)
            {
                question1.item = "Hand Hygiene";
            }
            else if (i > 12 && i < 15)
            {
                question1.item = "Gloves";
            }

            Question2 hello = new Question2();
            hello = question1;
            Test2[i] = question1;
            string json = JsonUtility.ToJson(question1);
            //Test2.Add(question1);
            Test.Add(json);
            string json12 = JsonUtility.ToJson(QQ);
            
            Debug.Log(UI.TextInfo[2].AnswerA);
            //File.WriteAllText(Application.dataPath + "/PPEQuestion" + i.ToString() + ".json", json);
            
        }
        string json2 = JsonConvert.SerializeObject(Test);
        string json3 = JsonConvert.SerializeObject(Test2);
        //Debug.Log(Test.Count);
        //File.WriteAllText(Application.dataPath + "/DonningQuestionsFake" + ".json", json2);
        //File.WriteAllText(Application.dataPath + "/DonningQuestions" + ".json", json3);





        for (int z = 16; z <35; z++)
        {
            Question2 question1 = new Question2();
            //QQ.Add(new QuizQuestion(UI.TextInfo[i].Info, UI.TextInfo[i].AnswerA, UI.TextInfo[i].AnswerB, UI.TextInfo[i].AnswerC, UI.TextInfo[i].AnswerD, UI.TextInfo[i].QuestText, UI.TextInfo[i].CurrentObject, UI.TextInfo[i].CurrentNumber));
            question1.QuestionsText = UI.TextInfo[z].Info;
            question1.OptionA = UI.TextInfo[z].AnswerA;
            question1.OptionB = UI.TextInfo[z].AnswerB;
            question1.OptionC = UI.TextInfo[z].AnswerC;
            question1.OptionD = UI.TextInfo[z].AnswerD;
            question1.QuestText = UI.TextInfo[z].QuestText;
            question1.CurrentObject = UI.TextInfo[z].CurrentObject;
            question1.CurrentNumber = UI.TextInfo[z].CurrentNumber;
            if (z == 16)
            {
                question1.item = "Shoe Covers";
            }
            else if (z > 16 && z < 21)
            {
                question1.item = "Gown";
            }
            else if (z > 20 && z < 26 )
            {
                question1.item = "Gloves";
            }
            else if (z == 26)
            {
                question1.item = "Hand Hygiene";
            }
            else if (z == 27)
            {
                question1.item = "Eye Protection";
            }
            else if (z == 28)
            {
                question1.item = "Head Covers";
            }
            else if (z > 28 && z < 34)
            {
                question1.item = "N95 Mask";
            }
            else if (z == 34)
            {
                question1.item = "";
            }

            Question2 hello = new Question2();
            hello = question1;
            DoffingQ[z - 16] = question1;
            
            //Test2.Add(question1);
            
            string json12 = JsonUtility.ToJson(QQ);

            Debug.Log(UI.TextInfo[2].AnswerA);
            

        }
        string Doffingjson = JsonConvert.SerializeObject(DoffingQ);
        //Debug.Log(Test.Count);
        //File.WriteAllText(Application.dataPath + "/DoffingQuestions" + ".json", Doffingjson);
        





        Debug.Log(Test2.Length);
        for (int j = 0; j < 10; j++)
        {
            Question2 question1 = new Question2();
            question1.QuestionsText = RSI.SGAQuestions[j].Info;
            question1.OptionA = RSI.SGAQuestions[j].AnswerA;
            question1.OptionB = RSI.SGAQuestions[j].AnswerB;
            question1.OptionC = RSI.SGAQuestions[j].AnswerC;
            question1.OptionD = RSI.SGAQuestions[j].AnswerD;
            question1.QuestText = RSI.SGAQuestions[j].QuestText;
            question1.CurrentObject = RSI.SGAQuestions[j].CurrentObject;
            question1.CurrentNumber = RSI.SGAQuestions[j].CurrentNumber;


            SGAQ[j] = question1;
            string json = JsonUtility.ToJson(question1);
            //Debug.Log(UI.TextInfo[2].AnswerA);
            //File.WriteAllText(Application.dataPath + "/SGAQuestion" + j.ToString() + ".json", json);
        }
        string SGAjson = JsonConvert.SerializeObject(SGAQ);
        //File.WriteAllText(Application.dataPath + "/SGAQuestions" + ".json", SGAjson);





        for (int k = 0; k < 13; k++)
        {
            Question2 question1 = new Question2();
            question1.QuestionsText = RSI.IntubationQuestions[k].Info;
            question1.OptionA = RSI.IntubationQuestions[k].AnswerA;
            question1.OptionB = RSI.IntubationQuestions[k].AnswerB;
            question1.OptionC = RSI.IntubationQuestions[k].AnswerC;
            question1.OptionD = RSI.IntubationQuestions[k].AnswerD;
            question1.QuestText = RSI.IntubationQuestions[k].QuestText;
            question1.CurrentObject = RSI.IntubationQuestions[k].CurrentObject;
            question1.CurrentNumber = RSI.IntubationQuestions[k].CurrentNumber;


            IQ[k] = question1;
            string json = JsonUtility.ToJson(question1);
            //Debug.Log(UI.TextInfo[2].AnswerA);
           // File.WriteAllText(Application.dataPath + "/IntubationQuestion" + k.ToString() + ".json", json);
        }

        string IQjson = JsonConvert.SerializeObject(IQ);
        File.WriteAllText(Application.dataPath + "/IntubationQuestions" + ".json", IQjson);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadLocalizedText(string fileName)
    {
        LocalizedText = new Dictionary<string, string>();
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if (File.Exists (filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            Debug.Log(dataAsJson);
            LocalizationData loadedData = JsonUtility.FromJson<LocalizationData>(dataAsJson);

            for (int i = 0; i < loadedData.items.Length; i++)
            {
                LocalizedText.Add(loadedData.items[i].key, loadedData.items[i].value);
            }
            Debug.Log("Data loaded, dictionary contains" + LocalizedText.Count + " entries");
        }
        else
        {
            Debug.LogError("not found!");
        }
    }
}


    public class QM2
    {

        public void Main(string[] args)
        {
            Question question1 = new Question();

            QuestionsManager QM = new QuestionsManager();
            question1.QuestionsText = QM.Info;
            question1.OptionA = QM.AnswerA;
            question1.OptionB = QM.AnswerB;
            question1.OptionC = QM.AnswerC;
            question1.OptionD = QM.AnswerD;
            question1.QuestText = QM.QuestText;
            question1.CurrentObject = QM.CurrentObject;
            question1.CurrentNumber = QM.CurrentNumber;


            string json = JsonUtility.ToJson(question1);
            Debug.Log("hello");
        }
    }

    public class Question2
    {
        public string item;

        public string QuestionsText;
        public string OptionA;
        public string OptionB;
        public string OptionC;
        public string OptionD;
        public string QuestText;
        public string CurrentObject;

        public string CurrentNumber;




    }



