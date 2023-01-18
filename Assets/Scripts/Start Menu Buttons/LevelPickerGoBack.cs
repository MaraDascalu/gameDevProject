using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPickerGoBack : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
