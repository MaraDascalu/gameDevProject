using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplayPlayerBestScoreAndName : MonoBehaviour
{
    public GameObject playerNameDisplay; 
    public GameObject playerBestScore;
    public static int playerBestScoreInt;

    public void Start(){
        playerNameDisplay.GetComponent<TMP_Text>().text = StartNewGameScript.playerName;
        playerBestScore.GetComponent<TMP_Text>().text = playerBestScoreInt.ToString();
    }

    public void OkButton(){
        SceneManager.LoadScene("StartMenu");
    }

}
