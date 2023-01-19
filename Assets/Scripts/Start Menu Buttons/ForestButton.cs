using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestButton : MonoBehaviour
{
    public GameObject price;

    void Update()
    {
        if (PlayerMovement.forestUnlocked == 1)
        {
            price.SetActive(false);
        }
        else
        {
            price.SetActive(true);
        }
    }

    public void GoToForestScene()
    {
        if (PlayerMovement.forestUnlocked == 0 && DisplayTotalCoins.currentTotalCoins >= 500)
        {
            DisplayTotalCoins.currentTotalCoins = DisplayTotalCoins.currentTotalCoins - 500;
            Time.timeScale = 1;
            PlayerMovement.map = 2;
            PlayerMovement.forestUnlocked = 1;
            SceneManager.LoadScene("City");
        }
        else if (PlayerMovement.forestUnlocked == 1)
        {
            Time.timeScale = 1;
            PlayerMovement.map = 2;
            SceneManager.LoadScene("City");
        }
    }
}
