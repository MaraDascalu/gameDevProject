using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public GameObject playerNameDisplay; 
    public void Start(){
        Debug.Log("00000");
        Debug.Log("*****" + StartNewGameScript.playerName);
        playerNameDisplay.GetComponent<TMP_Text>().text = StartNewGameScript.playerName;
    }
}
