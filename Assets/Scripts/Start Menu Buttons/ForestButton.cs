using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestButton : MonoBehaviour
{
    public void GoToForestScene()
    {
        Time.timeScale = 1;
        PlayerMovement.map = 2;
        SceneManager.LoadScene("City");
    }
}
