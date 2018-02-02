using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Date : MonoBehaviour{

    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;

    public object inputField { get; private set; }

    void Start () {
        string conn = "URI=file:" + Application.dataPath + "/Plugins/Joc.s3db;Pooling=true;FailIfMissing=false;Version=3";
}
	public void InsertIntoDB(int id,string name,int score)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open();
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("insert into Date (id,user, score) values (\"{0}\",\"{1}\",\"{2}\")",id, name, score);
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }
     void Deletvalue(int id)
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open();
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("Delete from Date WHERE id=\"{0}\"", id);
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }
    void Updatevalue(string name, int score,int id)
    {
        using (dbconn = new SqliteConnection(conn))
        {

            dbconn.Open(); 
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("UPDATE Date set user=\"{0}\", score=\"{1}\" WHERE id=\"{2}\" ", name,score, id);
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }
    }
    public void readers()
    {
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open();
            dbcmd = dbconn.CreateCommand();
            sqlQuery = "SELECT * " + "FROM Date";
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string user = reader.GetString(1);
                int score = reader.GetInt32(2);

                Debug.Log("value= " + id + "  user =" + user + "  score =" +score );
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
        }
    }

    string u = "username";

    string usernameString = string.Empty;
    string userID = string.Empty;

    Rect windowRect = new Rect(0, 0, Screen.width, Screen.height);
    private void OnGUI()
    {
        GUI.Window(0, windowRect, WindowFunction, "Start");
    }
    void WindowFunction(int WindowID)
    {

        usernameString = GUI.TextField(new Rect(Screen.width / 3, 2 * Screen.height / 5, Screen.width / 3, Screen.height / 10), usernameString, 10);
        userID = (GUI.TextField(new Rect(Screen.width / 3,   2*Screen.height / 3, Screen.width / 3, Screen.height / 10), userID, 10));
        if (GUI.Button(new Rect(Screen.width / 2, 4 * Screen.height / 5, Screen.width / 8, Screen.height / 10), "Start"))
        {
            InsertIntoDB(int.Parse(userID),usernameString, 0);
        }
        GUI.Label(new Rect(Screen.width / 3, 35 * Screen.height / 100, Screen.width / 5, Screen.height / 8), "User");
        GUI.Label(new Rect(Screen.width / 3, 60 * Screen.height / 100, Screen.width / 8, Screen.height / 8), "ID");


    }
}
