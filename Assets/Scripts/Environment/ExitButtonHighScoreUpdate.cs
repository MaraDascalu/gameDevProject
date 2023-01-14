using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class ExitButtonHighScoreUpdate : MonoBehaviour
{
    public GameObject coinsCount;
    public GameObject distanceCount;

    public void UpdateHighScore()
    {
        if (System.Convert.ToInt32(coinsCount.GetComponent<TMP_Text>().text) > DisplayPlayerBestScoreAndName.playerBestScoreInt){
            DisplayPlayerBestScoreAndName.playerBestScoreInt = System.Convert.ToInt32(coinsCount.GetComponent<TMP_Text>().text);
        }

        if (System.Convert.ToInt32(distanceCount.GetComponent<TMP_Text>().text) > DisplayPlayerBestScoreAndName.playerDistanceBestScoreInt){
            DisplayPlayerBestScoreAndName.playerDistanceBestScoreInt = System.Convert.ToInt32(distanceCount.GetComponent<TMP_Text>().text);
        }
    }
}
