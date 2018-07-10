﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    //name of player
    public string name;
    //password- might not be necessary, but for now we'l take it
    public string password;
    //amount of levels unlocked
    public int levelLock;

    //scores for every level
    public List<LevelData> levelData;
    //names of bonus itmes that the player has amassed
    public List<string> bonusItems;
    //list of quextion data
    public List<QuestionData> questionData;

    public PlayerInfo(string username, string inPassword)
    {
        name = username;
        password = inPassword;
        levelLock = 0;
        levelData = new List<LevelData>();
        questionData = new List<QuestionData>();
        for(int i = 0; i < 15; i++)
        {

            levelData.Add(new LevelData(i));

        }

        for(int i = 0; i < AnswerTable.answers.Length; i++)
        {

            questionData.Add(new QuestionData(i));

        }
        bonusItems = new List<string>();
    }

}


public class AnswerTable
{

    public static readonly string[] answers = {"B", "C", "C", "A", "B",
                                               "A", "D", "B", "B", "D",
                                               "A", "A", "B", "B", "B",
                                               "D", "B", "A", "A", "B",
                                               "A", "B", "B", "A", "A",

                                               "D", "A", "B", "B", "C",
                                               "B", "A", "C", "B", "D",
                                               "D", "D", "C", "B", "A",
                                               "A", "B", "A", "C", "C",
                                               "A", "B", "C", "A", "D",

                                               "D", "C", "A", "B", "B",
                                               "A", "D", "D", "B", "C",
                                               "B", "C", "C", "D", "A",
                                               "B", "B", "B", "C", "D",
                                               "C", "A", "B", "C", "C"};


}

[System.Serializable]
public class QuestionData
{
    public int questionNum;

    public List<string> times;

    public string answers;

    public string correctAnswer;

    public QuestionData(int num)
    {
        questionNum = num;
        times = new List<string>();
        answers = "";
        correctAnswer = AnswerTable.answers[num];
    }


}

[System.Serializable]
public class LevelData
{
    //level number
    public int levelNum;
    //score for the level
    public int score;
    //how many stars we got
    public int stars;
    //whether this level has been beaten for unlock
    public bool played;

    public LevelData(int num)
    {
        levelNum = num;
        score = 0;
        stars = 0;
        played = false;
    }

}