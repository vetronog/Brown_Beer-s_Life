﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionData : ScriptableObject
{
    [SerializeField] private string _questionTitle;

    public string GetQuestionTitle
    {
        get
        {
            return _questionTitle;
        }
    }
}