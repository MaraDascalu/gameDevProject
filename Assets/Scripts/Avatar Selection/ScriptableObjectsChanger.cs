using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectsChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] scriptableObjects;
    [SerializeField] private AvatarDisplay avatarDisplay;
    private int currentIndex;

    private void Start() {
        currentIndex = PlayerPrefs.GetInt("CharacterSelected");
        ChangeScripableObject(0);
    }

    public void ChangeScripableObject(int _change) {
        currentIndex += _change;

        if (currentIndex < 0) {
            currentIndex = scriptableObjects.Length - 1;
        }
        else
        {
            if (currentIndex == scriptableObjects.Length) {
                currentIndex = 0;
            }
        }

        if (avatarDisplay != null) {
            avatarDisplay.DisplayAvatar((Avatar)scriptableObjects[currentIndex]);
        }
    }
}
