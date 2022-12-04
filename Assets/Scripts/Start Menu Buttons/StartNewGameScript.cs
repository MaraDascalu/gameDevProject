using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartNewGameScript : MonoBehaviour
{
    public static string playerName = "";

    public void PlayNewGame(){ 
        // Debug.Log(playerName);
        SceneManager.LoadScene("City");
    }
}
