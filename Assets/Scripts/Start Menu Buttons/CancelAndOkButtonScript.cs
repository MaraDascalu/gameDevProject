using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CancelAndOkButtonScript : MonoBehaviour
{
    public void OkButton(){
        SceneManager.LoadScene("StartMenu");
    }

    public void CancelButton(){
        SceneManager.LoadScene("StartMenu");
    }
}
