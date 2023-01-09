using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class CoffeeCollect : MonoBehaviour
{
    public AudioSource coffeeSound;

    void OnTriggerEnter(Collider other)
    {   
        Debug.Log("Coffee sound");
        coffeeSound.Play();
        this.gameObject.SetActive(false);
        PlayerMovement._forwardSpeed += 0.5f;
        Debug.Log("PlayerSpeed: " + PlayerMovement._forwardSpeed);
        // yield return new WaitForSeconds(5f);
        // PlayerMovement._forwardSpeed = 10f;
        // Debug.Log(PlayerMovement._forwardSpeed);
        // this.gameObject.SetActive(true);

    }
     
}
