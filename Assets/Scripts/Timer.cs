using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class Timer : MonoBehaviour
{
    public StartGame startGame;
    public float elapsedTime;
    public TextMeshProUGUI timerText;
    String playTime;

    // Update is called once per frame
    void Update()
    {
        if (startGame.GetComponent<StartGame>().timerActive == false)
        {
            elapsedTime += Time.deltaTime;
        }

        timerText.text = elapsedTime.ToString("F0");


        // Save elapsed time to database

        playTime = $"INSERT INTO Timer (nimi, aika) VALUES('Creator', {timerText.text});";

    }

    public void InsertTime()
    {
        using (var connection = new SqliteConnection("URI=file:BallSorting.db"))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = playTime;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }


}


