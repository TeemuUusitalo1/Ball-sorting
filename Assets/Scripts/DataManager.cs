using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using TMPro;

public class DataManager : MonoBehaviour
{
    public GameCheck gameCheck;
    public Timer timer;
    private IDbConnection dbConnection;

    [SerializeField] private TMP_Text textArea;

    private void Start()
    {
        LoadTextIntoTextBox();
    }

    public void Update()
    {

    }
    public void LoadTextIntoTextBox()
    {
        using var connection = new SqliteConnection("URI=file:BallSorting.db");
        connection.Open();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Timer ORDER BY aika ASC LIMIT 5;";

        using IDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            string pelaajanNimi = reader.GetString(1);
            int pisteet = reader.GetInt32(2);
            textArea.text += $"Pelaajan nimi: {pelaajanNimi}, Aika: {pisteet} sekunttia<br>";
            //Debug.Log($"Pelaajan nimi: {pelaajanNimi}, Pisteet: {pisteet}");
        }
        reader.Close();
    }
}

