using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using TMPro;

public class HallOfFame : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;

    void Start()
    {
        string[] fileEntries = Directory.GetFiles(Application.dataPath + "/StreamingAssets/PlayersData");
        List<Save> players = new List<Save>();

        foreach (string fileName in fileEntries)
            if (!fileName.Contains(".meta"))
            {
                StreamReader sr = new StreamReader(fileName);
                string JsonString = sr.ReadToEnd();
                sr.Close();

                Save save = JsonUtility.FromJson<Save>(JsonString);

                players.Add(save);
            }

        players.Sort((p1, p2) =>
        {
            return p1.CompareTo(p2);
        });

        if (players.Count >= 5)
        {
            first.GetComponent<TMP_Text>().text = "1. " + players[0].playerName + " - " + players[0].distanceHighscore.ToString();
            second.GetComponent<TMP_Text>().text = "2. " + players[1].playerName + " - " + players[1].distanceHighscore.ToString();
            third.GetComponent<TMP_Text>().text = "3. " + players[2].playerName + " - " + players[2].distanceHighscore.ToString();
            fourth.GetComponent<TMP_Text>().text = "4. " + players[3].playerName + " - " + players[3].distanceHighscore.ToString();
            fifth.GetComponent<TMP_Text>().text = "5. " + players[4].playerName + " - " + players[4].distanceHighscore.ToString();
        }
    }
}
