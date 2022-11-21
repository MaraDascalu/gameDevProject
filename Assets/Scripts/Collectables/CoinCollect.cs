using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioSource coinSound;

    void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        CollectableControl.coinCounter += 1;
        this.gameObject.SetActive(false);
    }
}
