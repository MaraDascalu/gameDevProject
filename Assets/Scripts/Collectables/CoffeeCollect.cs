using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoffeeCollect : MonoBehaviour
{
    public AudioSource coffeeSound;

    public void Wait()
    {
        StartCoroutine(_wait());
    }

    IEnumerator _wait()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(5);
        PlayerMovement._forwardSpeed = 10.0f;
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        Debug.Log(PlayerMovement._forwardSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coffee sound");
        coffeeSound.Play();
        this.gameObject.SetActive(true);
        PlayerMovement._forwardSpeed += 20.0f;
        Debug.Log("PlayerSpeed: " + PlayerMovement._forwardSpeed);
        Wait();
        Debug.Log(PlayerMovement._forwardSpeed);

    }

}
