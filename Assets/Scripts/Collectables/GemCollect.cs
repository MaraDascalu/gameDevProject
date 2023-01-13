using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public AudioSource gemSound;
    public Wait wait;
    public GameObject coinBonus;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("GemSound");
        wait.BonusCoin(coinBonus);
        gemSound.Play();
        CollectableControl.coinCounter += 50;
        this.gameObject.SetActive(false);
    }
}



