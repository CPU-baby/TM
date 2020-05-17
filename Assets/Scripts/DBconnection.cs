using System;
using System.Data;
using Mono.Data.SqliteClient;
using System.IO;
using UnityEngine.Networking;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBConnection : MonoBehaviour
{
    void Awake()
    {
        StartCoroutine(DBCreate());
    }
    IEnumerator DBCreate()
    {
        string filePath = string.Empty;
        filePath = Application.dataPath + "/ranking.db";
        if (!File.Exists(filePath))
        {
            File.Copy(Application.streamingAssetsPath + "/ranking.db", filePath);
        } 
        Debug.Log("DB 생성 완료");
        yield return null;
    }

    public static string GetDBFilePath()
    {
        string str = "URI=file:" + Application.dataPath + "/ranking.db";

        IDbConnection dbConn = new SqliteConnection(str);
        dbConn.Open();

        string sql = "CREATE TABLE IF NOT EXISTS TalRanking ( " +
             "num INTEGER PRIMARY KEY AUTOINCREMENT, " +
             "name  TEXT NOT NULL, " +
             "belong TEXT, " +
             "score INTEGER NOT NULL DEFAULT 0);";
        IDbCommand dbCommand = dbConn.CreateCommand();
        dbCommand.CommandText = sql;
        IDataReader dataReader = dbCommand.ExecuteReader();

        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConn.Dispose();
        dbConn = null;
        return str;
    }

    // Start is called before the first frame update
    void Start()
    {
        DBConnectionCheck();
        insertPlayer();
        //updateScore("원예린");
    }
    public void DBConnectionCheck()
    {
        try
        {
            IDbConnection dbConn = new SqliteConnection(GetDBFilePath());
            dbConn.Open();

            if (dbConn.State == ConnectionState.Open)
            {
                Debug.Log("DB연결 성공");
            }
            else
            {
                Debug.Log("DB연결 실패");
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    //플레이어추가 (매개변수 값 : 이름, 소속)
    public void insertPlayer()
    {
        string name = "농농";
        string belong = "글쎼염";
        //이름은 TextField로 받아오는 걸로 하기

        if (!checkPlayer(name))
        {
            return; //중복이름
        }

        IDbConnection dbConn = new SqliteConnection(GetDBFilePath());
        dbConn.Open();
        
        string sql = "insert into TalRanking (num, name, belong) values (0, '" + name + "', '" + belong + "');";
        IDbCommand dbCommand = dbConn.CreateCommand();
        dbCommand.CommandText = sql;
        IDataReader dataReader = dbCommand.ExecuteReader();

        sql = "select num from TalRanking where name = " + name + " and belong = " + belong;
        dbCommand.CommandText = sql;
        dataReader = dbCommand.ExecuteReader();

        if(dataReader.Read())
        {
            Debug.Log(dataReader.GetInt32(0));
        }

        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConn.Dispose();
        dbConn = null;
    }

    //중복이면 false, 아니면 true
    public bool checkPlayer(String name)
    {
        bool check = false;

        IDbConnection dbConn = new SqliteConnection(GetDBFilePath());
        dbConn.Open();

        string sql = "select count(*) from TalRanking where name = '" + name + "'";
        IDbCommand dbCommand = dbConn.CreateCommand();
        dbCommand.CommandText = sql;
        IDataReader dataReader = dbCommand.ExecuteReader();

        if (dataReader.Read())
        {
            if(dataReader.GetInt32(0) == 0)
            {
                check = true;
            }
        }

        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConn.Dispose();
        dbConn = null;
        return check;
    }


    public void updateScore(int num, int score)
    {

        IDbConnection dbConn = new SqliteConnection(GetDBFilePath());
        dbConn.Open();

        string sql = "update TalRanking set score = " + score + " where name = '" + name + "'";
        IDbCommand dbCommand = dbConn.CreateCommand();
        dbCommand.CommandText = sql;
        IDataReader dataReader = dbCommand.ExecuteReader();

        dataReader.Dispose();
        dataReader = null;
        dbCommand.Dispose();
        dbCommand = null;
        dbConn.Dispose();
        dbConn = null;
    }

    
}
