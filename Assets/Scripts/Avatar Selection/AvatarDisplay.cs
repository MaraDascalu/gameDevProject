using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarDisplay : MonoBehaviour
{
    [SerializeField] private Text avatarName;

    public void DisplayAvatar(Avatar _avatar) {
        avatarName.text = _avatar.avatarName;
    }
}
