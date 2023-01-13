using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartNewGameScript : MonoBehaviour
{
    public static string playerName = "Player";
    //int value = 0;

    class SetInitialVolume
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void OnBeforeSceneLoadRuntimeMethod() => VolumeSlider.volume = 0.5f;
    }

    public void PlayNewGame(){ 

        CollectableControl.coinCounter = 0;
        SceneManager.LoadScene("LevelPicker");
    }
}
