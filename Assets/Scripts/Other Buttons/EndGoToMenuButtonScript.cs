using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoToMenuButtonScript : MonoBehaviour
{
    public void GoToMenuScene(){ 
        SceneManager.LoadScene("StartMenu");
    }

    public void TotalCoinsUpdate(){
        DisplayTotalCoins.currentTotalCoins += CollectableControl.coinCounter;
    }
}
