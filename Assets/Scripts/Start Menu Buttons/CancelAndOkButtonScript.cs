using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CancelAndOkButtonScript : MonoBehaviour
{
    public TMP_InputField inputFieldGame;

    public void OkButton(){
        string name = inputFieldGame.text;
        StartNewGameScript.playerName = name;
        
        SceneManager.LoadScene("StartMenu");
        // Debug.Log(playerName);
    }

    public void CancelButton(){
        SceneManager.LoadScene("StartMenu");
    }
}



