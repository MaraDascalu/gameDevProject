using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBestScoreScript : MonoBehaviour
{
    public void GoToPlayerBestScoreScene(){ 
        SceneManager.LoadScene("PlayerBestScore");
    }
}
