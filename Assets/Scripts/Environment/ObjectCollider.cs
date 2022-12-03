using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public GameObject player;
    public GameObject model;
    public AudioSource hitSound;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        model.GetComponent<Animator>().Play("Falling");
        hitSound.Play();
    }
}
