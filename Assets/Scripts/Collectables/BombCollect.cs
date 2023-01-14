using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollect : MonoBehaviour
{
    public AudioSource bombSound;
    public Wait wait;
    public GameObject coinMinus;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("BombSound");
        wait.MinusCoin(coinMinus);
        bombSound.Play();
        CollectableControl.coinCounter = Math.Max(0, CollectableControl.coinCounter - 50);
        this.gameObject.SetActive(false);
    }
}



