using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wait : MonoBehaviour
{
    IEnumerator CoinBonus(GameObject coinBonus)
    {
        coinBonus.SetActive(true);
        yield return new WaitForSeconds(1);
        coinBonus.SetActive(false);
    }

    public void BonusCoin(GameObject coinBonus)
    {
        StartCoroutine(CoinBonus(coinBonus));
    }

    IEnumerator CoinMinus(GameObject coinMinus)
    {
        coinMinus.SetActive(true);
        yield return new WaitForSeconds(1);
        coinMinus.SetActive(false);
    }

    public void MinusCoin(GameObject coinMinus)
    {
        StartCoroutine(CoinMinus(coinMinus));
    }

    public void CoffeeWait(GameObject countdown, GameObject countdownDisplay)
    {
        StartCoroutine(Coffee(countdown, countdownDisplay));
    }

    IEnumerator Coffee(GameObject countdown, GameObject countdownDisplay)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        countdown.SetActive(true);
        countdownDisplay.GetComponent<TMP_Text>().text = "0:05";
        yield return new WaitForSeconds(1);
        countdownDisplay.GetComponent<TMP_Text>().text = "0:04";
        yield return new WaitForSeconds(1);
        countdownDisplay.GetComponent<TMP_Text>().text = "0:03";
        yield return new WaitForSeconds(1);
        countdownDisplay.GetComponent<TMP_Text>().text = "0:02";
        yield return new WaitForSeconds(1);
        countdownDisplay.GetComponent<TMP_Text>().text = "0:01";
        yield return new WaitForSeconds(1);
        countdown.SetActive(false);
        PlayerMovement._forwardSpeed = 10.0f;
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        Debug.Log(PlayerMovement._forwardSpeed);
    }

}
