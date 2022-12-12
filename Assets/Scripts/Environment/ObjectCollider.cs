using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public GameObject player;
    public GameObject model;
    public AudioSource hitSound;
    public GameObject mainCamera;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        model.GetComponent<Animator>().Play("Falling");
        levelControl.GetComponent<RunCounter>().enabled = false;
        hitSound.Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunDisplay>().enabled = true;
    }
}
