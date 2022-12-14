using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestButton : MonoBehaviour
{
    public void GoToForestScene()
    {
        SceneManager.LoadScene("Forest");
    }
}
