using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunDisplay : MonoBehaviour
{
    public GameObject coinsLiveScore;
    public GameObject runLiveScore;
    public GameObject endScore;
    public GameObject fade;
    public GameObject gameOverText;
    public GameObject nameDisplay;

    void Start()
    {
        StartCoroutine(EndDisplay());
    }

    IEnumerator EndDisplay()
    {
        yield return new WaitForSeconds(3);
        coinsLiveScore.SetActive(false);
        runLiveScore.SetActive(false);
        nameDisplay.SetActive(false);
        endScore.SetActive(true);
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(3);
        fade.SetActive(true);
    }
}
