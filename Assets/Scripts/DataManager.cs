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
    private string connectionString;
    private IDbConnection dbConnection;

    [SerializeField] private TMP_Text textArea;



    // Start is called before the first frame update
    void Start()
    {
        connectionString = "URI=file:YksiloProjekti.db";

        dbConnection = new SqliteConnection(connectionString);
        dbConnection.Open();

        FetchData();
    }

    public void FetchData()
    {
        using (IDbCommand dbCmd = dbConnection.CreateCommand())
        {
            dbCmd.CommandText = "SELECT * FROM TulosTaulu ORDER BY pisteet DESC, pelaajan_nimi limit 5;";
            using (IDataReader reader = dbCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string pelaajanNimi = reader.GetString(1);
                    int pisteet = reader.GetInt32(2);



                    textArea.text += $"Pelaajan nimi: {pelaajanNimi}, Pisteet: {pisteet}<br>";
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
