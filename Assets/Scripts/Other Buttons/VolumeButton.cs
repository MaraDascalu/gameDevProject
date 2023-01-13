using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeButton : MonoBehaviour
{
    public GameObject slider;

    public void EnableSlider()
    {
        if (slider.activeSelf)
            slider.SetActive(false);
        else
            slider.SetActive(true);
    }
}
