using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public static float volume;
    public Slider slider;
    public AudioSource coinSound;
    public AudioSource hitSound;
    public AudioSource gemSound;
    public AudioSource goSound;
    public AudioSource readySound;
    public AudioSource coffeeSound;
    public AudioSource shieldSound;
    public AudioSource bombSound;
    public AudioSource backgroundSound;
    public AudioSource gameOverSound;

    void Update()
    {
        coinSound.volume = slider.value;
        hitSound.volume = slider.value;
        gemSound.volume = slider.value;
        goSound.volume = slider.value;
        readySound.volume = slider.value;
        shieldSound.volume = slider.value;
        bombSound.volume = slider.value;
        backgroundSound.volume = slider.value;
        gameOverSound.volume = slider.value;
        coffeeSound.volume = slider.value;
    }
}
