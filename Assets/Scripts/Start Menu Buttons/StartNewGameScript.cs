using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGameScript : MonoBehaviour
{
    public void PlayNewGame(){ 
        SceneManager.LoadScene("City");
    }
}
