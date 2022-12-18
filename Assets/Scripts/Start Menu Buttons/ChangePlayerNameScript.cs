using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangePlayerNameScript : MonoBehaviour
{
    public void GoToPlayerNameChangeScene(){ 
        SceneManager.LoadScene("PlayerNameChange");
    }
}
