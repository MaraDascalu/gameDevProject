using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AvatarSelection : MonoBehaviour
{
    private GameObject[] avatarList;
    private int index;

    private void Start() {
        index = PlayerPrefs.GetInt("CharacterSelected");
        
        avatarList = new GameObject[transform.childCount];

        //Fill the array with our models
        for (int i = 0 ; i < transform.childCount ; i++) {
            avatarList[i] = transform.GetChild(i).gameObject;
        }

        //We toggle off their renderer
        foreach (GameObject avatar in avatarList){
            avatar.SetActive(false);
        }

        //We toogle on the selected avatar
        if (avatarList[index])
            avatarList[index].SetActive(true);
    }

    public void ChangeAvatar(int _change) {
        //Toggle off the current model
        avatarList[index].SetActive(false);

        index += _change;
        if (index < 0) {
            index = avatarList.Length - 1;
        }
        else {
            if (index == avatarList.Length)
                index = 0;
        }

        //Toggle on the new model
        avatarList[index].SetActive(true);
    }

    public void PlayNewGame(){ 
        CollectableControl.coinCounter = 0;
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("LevelPicker");
    }
}
