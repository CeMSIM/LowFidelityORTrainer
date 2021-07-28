using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonParser : MonoBehaviour
{
    
        public TextAsset PPEDonQs;
        public TextAsset PPEDoffQs;
        public TextAsset IntQs;
        public TextAsset SGAQs;

        public QuestionsManager[] test;
        [System.Serializable]
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

        [System.Serializable]
        public class DonQuestionsArray
        {
            public Question2[] Don;
        }


        [System.Serializable]
        public class DoffQuestionsArray
        {
            public Question2[] Doff;
        }



        [System.Serializable]
        public class IntQuestionsArray
        {
            public Question2[] Intubation;
        }



        [System.Serializable]
        public class SGAQuestionsArray
        {
            public Question2[] SGA;
        }


        public DonQuestionsArray myDonningQuestions = new DonQuestionsArray();
        public DoffQuestionsArray myDoffingQuestions = new DoffQuestionsArray();
        public IntQuestionsArray myIntubationQuestions = new IntQuestionsArray();
        public SGAQuestionsArray mySGAIntubationQuestions = new SGAQuestionsArray();
        // Start is called before the first frame update
        void Start()
    {
        myDonningQuestions = JsonUtility.FromJson<DonQuestionsArray>(PPEDonQs.text);
        myDoffingQuestions = JsonUtility.FromJson<DoffQuestionsArray>(PPEDoffQs.text);
        myIntubationQuestions = JsonUtility.FromJson<IntQuestionsArray>(IntQs.text);
        mySGAIntubationQuestions = JsonUtility.FromJson<SGAQuestionsArray>(SGAQs.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
