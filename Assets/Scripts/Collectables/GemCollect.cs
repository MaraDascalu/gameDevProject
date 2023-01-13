using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public AudioSource gemSound;

     void OnTriggerEnter(Collider other)
    {
        Debug.Log("GemSound");
        gemSound.Play();
        CollectableControl.coinCounter += 100;
        this.gameObject.SetActive(false);
    }
}



