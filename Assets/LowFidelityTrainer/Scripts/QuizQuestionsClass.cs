using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuizQuestion
{
    public string QuestionInfo;
    public string AnswerA;
    public string AnswerB;
    public string AnswerC;
    public string AnswerD;
    public string QuestText;
    public string CurrentObject;
    public string CurrentNumber;


    public QuizQuestion(string newQuestionInfo, string newAnswerA, string newAnswerB, string newAnswerC, string newAnswerD, string newQuestText, string newCurrentObject, string newCurrentNumber)
    {
        QuestionInfo = newQuestionInfo;
        AnswerA = newAnswerA;
        AnswerB = newAnswerB;
        AnswerC = newAnswerC;
        AnswerD = newAnswerD;
        QuestText = newQuestText;
        CurrentObject = newCurrentObject;
        CurrentNumber = newCurrentNumber;

    }
}

