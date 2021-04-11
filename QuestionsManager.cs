﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Answer
{
    [SerializeField] private string _info;
    public string Info { get { return _info; } }

    [SerializeField] private string _answerA;
    public string AnswerA { get { return _answerA; } }

    [SerializeField] private string _answerB;
    public string AnswerB { get { return _answerB; } }

    [SerializeField] private bool _Correct;
    public bool Correct { get { return _Correct; } }
}
[CreateAssetMenu(fileName = "New Question", menuName = "Quiz/new Question")]
public class QuestionsManager : ScriptableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    

    [SerializeField] private string _info = string.Empty;
    public string Info { get { return _info; } }

    [SerializeField] private string _answerA;
    public string AnswerA {  get { return _answerA; } }

    [SerializeField] private string _answerB;
    public string AnswerB { get { return _answerB; } }

    [SerializeField] private string _answerC;
    public string AnswerC { get { return _answerC; } }

    [SerializeField] private string _answerD;
    public string AnswerD { get { return _answerD; } }

    [SerializeField] private string _questText;
    public string QuestText { get { return _questText; } }


    //Parameters

    [SerializeField] private bool _useTimer = false;
    public bool UseTimer { get { return _useTimer; } }

    [SerializeField] private int _timer = 0;
    public int Timer { get { return _timer; } }



}
