using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollect : MonoBehaviour
{
    public AudioSource shieldSound;

     void OnTriggerEnter(Collider other)
    {
        Debug.Log("Shield Sound");
        shieldSound.Play();
        // this.gameObject.SetActive(false);
    }
}