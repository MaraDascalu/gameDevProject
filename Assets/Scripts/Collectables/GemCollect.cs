using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public AudioSource gemSound;

     void OnTriggerEnter(Collider other)
    {
        gemSound.Play();
        CollectableControl.coinCounter += CollectableControl.coinCounter;
        this.gameObject.SetActive(false);
    }
}



