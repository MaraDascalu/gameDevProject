using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollider : MonoBehaviour
{
    public GameObject player;
    public GameObject model;
    private GameObject avatar;
    public AudioSource hitSound;
    public GameObject mainCamera;
    public GameObject levelControl;

    private int avatarIndex;

    void OnTriggerEnter(Collider other)
    {
        avatarIndex = PlayerPrefs.GetInt("CharacterSelected");
        Debug.Log(avatarIndex);
        avatar = model.transform.GetChild(avatarIndex).gameObject;

        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        avatar.GetComponent<Animator>().Play("Falling");
        levelControl.GetComponent<RunCounter>().enabled = false;
        hitSound.Play();
        mainCamera.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunDisplay>().enabled = true;
    }
}
