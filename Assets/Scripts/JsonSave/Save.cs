using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save
{
    public int totalCoins;
    public string playerName;
    public int distanceHighscore;
    public int coinHighscore;
    public int forestUnlocked;

    public int CompareTo(Save save)
    {
        if (this.distanceHighscore < save.distanceHighscore)
            return 1;
        else if (this.distanceHighscore > save.distanceHighscore)
            return -1;
        else
            return 0;
    }
}
