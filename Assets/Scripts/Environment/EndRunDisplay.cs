using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndRunDisplay : MonoBehaviour
{
    public GameObject coinsLiveScore;
    public GameObject runLiveScore;
    public GameObject endScore;
    public GameObject gameOverText;
    public GameObject nameDisplay;
    public GameObject endButton;
    public GameObject coinsCount;
    public GameObject distanceCount;
    public AudioSource endSound;
    public AudioSource backgroundSound;
    public Slider slider;

    void Start()
    {
        StartCoroutine(EndDisplay());
    }

    IEnumerator EndDisplay()
    {
        backgroundSound.Stop();
        endSound.Play();
        yield return new WaitForSeconds(3);
        coinsLiveScore.SetActive(false);
        runLiveScore.SetActive(false);
        nameDisplay.SetActive(false);
        endScore.SetActive(true);
        gameOverText.SetActive(true);
        endButton.SetActive(true);
        PlayerMovement.ableToMove = false;

        if (System.Convert.ToInt32(coinsCount.GetComponent<TMP_Text>().text) > DisplayPlayerBestScoreAndName.playerBestScoreInt){
            DisplayPlayerBestScoreAndName.playerBestScoreInt = System.Convert.ToInt32(coinsCount.GetComponent<TMP_Text>().text);
        }

        if (System.Convert.ToInt32(distanceCount.GetComponent<TMP_Text>().text) > DisplayPlayerBestScoreAndName.playerDistanceBestScoreInt){
            DisplayPlayerBestScoreAndName.playerDistanceBestScoreInt = System.Convert.ToInt32(distanceCount.GetComponent<TMP_Text>().text);
        }

        VolumeSlider.volume = slider.value;

        yield return new WaitForSeconds(3);
    }
}
