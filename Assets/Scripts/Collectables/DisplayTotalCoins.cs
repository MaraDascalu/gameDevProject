using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayTotalCoins : MonoBehaviour
{
    public GameObject totalCoins;
    public static int currentTotalCoins;

    void Start()
    {
        // currentTotalCoins += CollectableControl.coinCounter;
        totalCoins.GetComponent<TMP_Text>().text = currentTotalCoins.ToString();
    }
}
