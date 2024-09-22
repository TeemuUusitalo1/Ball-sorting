using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mono.Data.Sqlite;
using System.Data;

public class Timer : MonoBehaviour
{
    public StartGame startGame;
    public float timeStart;
    private static Timer _timer;
    public TextMeshProUGUI textBox;
    [SerializeField] private float countdownTimer = 0;
    private IDbConnection dbConnection;
    private string connectionString;


    private void Awake()
    {
        connectionString = "URI=file:YksiloProjekti.db";
    }

    // Start is called before the first frame update
    void Start()
    {

       // textBox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (startGame.GetComponent<StartGame>().timerActive == true && countdownTimer > 0)
        {
            SaveTimeToDatabase();
        } else if (startGame.GetComponent<StartGame>().timerActive == false) {
            timeStart += Time.deltaTime;
        }

        int minutes = Mathf.FloorToInt(startGame.GetComponent<StartGame>().timerActive ? countdownTimer / 60f : timeStart / 60f);
        int seconds = Mathf.FloorToInt(startGame.GetComponent<StartGame>().timerActive ? countdownTimer - minutes * 60 : timeStart - minutes * 60);
        textBox.text = string.Format("{0:00}:{1:00}", minutes, seconds);
       // timeStart += Time.deltaTime;
      //  textBox.text = timeStart.ToString("F2");
    }

    private void SaveTimeToDatabase()
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (var dbCommand = dbConnection.CreateCommand())
            {

                dbCommand.CommandText = $"INSERT INTO TulosTaulu (pelaajan_nimi, pisteet) VALUES ('Pelaaja1', {timeStart});";
              //  dbCommand.Parameters.Add(new SqliteParameter("@timeStart", timeStart));
                dbCommand.ExecuteNonQuery();
            }
        }
    }

}


