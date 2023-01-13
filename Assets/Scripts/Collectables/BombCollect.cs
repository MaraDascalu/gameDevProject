using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollect : MonoBehaviour
{
    public AudioSource bombSound;

     void OnTriggerEnter(Collider other)
    {
        Debug.Log("BombSound");
        bombSound.Play();
        CollectableControl.coinCounter -= 50;
        this.gameObject.SetActive(false);
    }
}



