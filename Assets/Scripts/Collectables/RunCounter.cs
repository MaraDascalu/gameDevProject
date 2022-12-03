using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RunCounter : MonoBehaviour
{
    public GameObject runDisplay;
    public int runCount;
    public bool runIncrease = false;

    void Update()
    {
        if (runIncrease == false)
        {
            runIncrease = true;
            StartCoroutine(RunCountIncrease());
        }
    }

    IEnumerator RunCountIncrease()
    {
        runCount++;
        runDisplay.GetComponent<TMP_Text>().text = "" + runCount;
        yield return new WaitForSeconds(0.25f);
        runIncrease = false;
    }
}
