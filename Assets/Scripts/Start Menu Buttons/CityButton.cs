using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CityButton : MonoBehaviour
{
    public void GoToCityButton()
    {
        SceneManager.LoadScene("City");
    }
}
