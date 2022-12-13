using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartNewGameScript : MonoBehaviour
{
    public static string playerName = "Player";

    public void PlayNewGame(){ 
        // Debug.Log(playerName);
        CollectableControl.coinCounter = 0;
        SceneManager.LoadScene("City");
    }
}
