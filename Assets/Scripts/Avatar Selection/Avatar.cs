using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Avatar", menuName = "Scriptable Objects/Avatar")]

public class Avatar : ScriptableObject
{
    public int avatarIndex;
    public string avatarName;
    public Object sceneToLoad;
}
