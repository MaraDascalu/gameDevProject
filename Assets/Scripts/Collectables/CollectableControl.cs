using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{
    public static int coinCounter = 0;
    public static int totalCoinsInt = 0;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;
    public GameObject playerEndDisplay;
    public GameObject playerNameDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TMP_Text>().text = "" + coinCounter;
        coinEndDisplay.GetComponent<TMP_Text>().text = "" + coinCounter;
        playerEndDisplay.GetComponent<TMP_Text>().text = "Game Over " + playerNameDisplay.GetComponent<TMP_Text>().text;
    }
}
