using System;
using System.Data;
using Mono.Data.SqliteClient;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{

    Text grade;
    Text belong;
    Text name;
    Text score;
    Text userGrade;
    Text userBelong;
    Text userName;
    Text userScore;


    // Start is called before the first frame update
    void Start()
    {
        userGrade = GameObject.Find("userGrade").GetComponent<Text>();
        userBelong = GameObject.Find("userBelong").GetComponent<Text>();
        userName = GameObject.Find("userName").GetComponent<Text>();
        userScore = GameObject.Find("userScore").GetComponent<Text>();
        readRanking(1);
        //안에 들어갈 숫자는 앞에서 가져온 값
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
            //SceneManager.LoadScene("");
        }
    }

        public void readRanking(int num )
    {
        int i = 0;
         IDbConnection dbConn = new SqliteConnection(DBConnection.GetDBFilePath());
        dbConn.Open();

        string sql = "Select * from TalRanking order by score desc limit 10";
        IDbCommand dbCommand = dbConn.CreateCommand();
        dbCommand.CommandText = sql;
        IDataReader dataReader = dbCommand.ExecuteReader();

        while (dataReader.Read())
        {
            i++;
            Debug.Log(i);
            grade = GameObject.Find("grade" + i).GetComponent<Text>();
            grade.text = i.ToString();
            belong = GameObject.Find("belong" + i).GetComponent<Text>();
            belong.text = dataReader.GetString(2);
            name = GameObject.Find("name" + i).GetComponent<Text>();
            name.text = dataReader.GetString(1);
            score = GameObject.Find("score" + i).GetComponent<Text>();
            score.text = dataReader.GetInt32(3).ToString();
        }

        sql = "Select * from TalRanking";
        dbCommand.CommandText = sql;
        dataReader = dbCommand.ExecuteReader();

        while (dataReader.Read())
        {
            if(num == dataReader.GetInt32(0))
            {
                userGrade.text = dataReader.GetInt32(0).ToString();
                userBelong.text = dataReader.GetString(2);
                userName.text = dataReader.GetString(1);
                userScore.text = dataReader.GetInt32(3).ToString();
            }
        }

        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConn.Dispose();
        dbConn = null;
    }
}
