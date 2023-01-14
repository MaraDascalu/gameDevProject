using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CityButton : MonoBehaviour
{
    public void GoToCityButton()
    {
        Time.timeScale = 1;
        PlayerMovement.map = 1;
        SceneManager.LoadScene("City");

    }
}
