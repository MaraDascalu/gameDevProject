using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseAvatarButton : MonoBehaviour
{
    public void GoToAvatarMenu(){ 
        SceneManager.LoadScene("AvatarMenu");
    }
}
