using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBackButton : MonoBehaviour
{
    public Slider slider;

    public void GoBack()
    {
        VolumeSlider.volume = slider.value;
        SceneManager.LoadScene("StartMenu");
    }
}
