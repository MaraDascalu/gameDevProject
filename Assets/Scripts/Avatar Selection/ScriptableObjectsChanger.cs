using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectsChanger : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] scriptableObjects;
    [SerializeField] private AvatarDisplay avatarDisplay;
    private int currentIndex;

    private void Awake() {
        ChangeScripableObject(0);
    }

    public void ChangeScripableObject(int _change) {
        currentIndex += _change;

        if (avatarDisplay != null) {
            avatarDisplay.DisplayAvatar((Avatar)scriptableObjects[currentIndex]);
        }
    }
}
