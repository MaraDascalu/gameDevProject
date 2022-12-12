using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject count3;
    public GameObject count2;
    public GameObject count1;
    public GameObject countGo;
    public GameObject fade;
    public AudioSource readySound;
    public AudioSource goSound;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(2.0f);
        count3.SetActive(true);
        readySound.Play();
        yield return new WaitForSeconds(1.0f);
        count2.SetActive(true);
        readySound.Play();
        yield return new WaitForSeconds(1.0f);
        count1.SetActive(true);
        readySound.Play();
        yield return new WaitForSeconds(1.0f);
        countGo.SetActive(true);
        goSound.Play();
        PlayerMovement.ableToMove = true;
    }
}
