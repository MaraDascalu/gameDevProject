using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{
    public static int coinCounter = 0;
    public GameObject cointCountDisplay;

    void Update()
    {
        cointCountDisplay.GetComponent<TMP_Text>().text = "" + coinCounter;
    }
}
