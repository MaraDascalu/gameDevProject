using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoffeeCollect : MonoBehaviour
{
    public AudioSource coffeeSound;
    public Wait wait;
    public GameObject countdown;
    public GameObject countdownDisplay;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coffee sound");
        coffeeSound.Play();
        PlayerMovement._forwardSpeed = 20.0f;
        Debug.Log("PlayerSpeed: " + PlayerMovement._forwardSpeed);
        wait.CoffeeWait(countdown, countdownDisplay);
        Debug.Log(PlayerMovement._forwardSpeed);
        this.gameObject.SetActive(false);
    }

}
