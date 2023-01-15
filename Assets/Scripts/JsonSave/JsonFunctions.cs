using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class JsonFunctions : MonoBehaviour
{
        public void SaveButton()
        {
            SaveByJSON();
        }

        public void LoadButton()
        {
            LoadByJSON();
        }

        private Save createSaveGameObject()
        {
            Save save = new Save();

            save.totalCoins = DisplayTotalCoins.currentTotalCoins;
            save.playerName = StartNewGameScript.playerName;
            save.distanceHighscore = DisplayPlayerBestScoreAndName.playerDistanceBestScoreInt;
            save.coinHighscore = DisplayPlayerBestScoreAndName.playerBestScoreInt;

            return save;
        }

        private void SaveByJSON()
        {
            Save save = createSaveGameObject();

            string JsonString = JsonUtility.ToJson(save);
            StreamWriter sw = new StreamWriter(Application.dataPath + "/StreamingAssets/PlayersData/" + StartNewGameScript.playerName + ".txt");
            sw.Write(JsonString);
            sw.Close();

            Debug.Log("Saved to " + StartNewGameScript.playerName + " JSON");
        }

        private void LoadByJSON()
        {
            if(File.Exists(Application.dataPath + "/StreamingAssets/PlayersData/" + StartNewGameScript.playerName + ".txt"))
            {

                StreamReader sr = new StreamReader(Application.dataPath + "/StreamingAssets/PlayersData/" + StartNewGameScript.playerName + ".txt");
                string JsonString = sr.ReadToEnd();
                sr.Close();

                Save save = JsonUtility.FromJson<Save>(JsonString);

                DisplayTotalCoins.currentTotalCoins = save.totalCoins;
                StartNewGameScript.playerName = save.playerName;
                DisplayPlayerBestScoreAndName.playerDistanceBestScoreInt = save.distanceHighscore;
                DisplayPlayerBestScoreAndName.playerBestScoreInt = save.coinHighscore;
            }
            else
            {
                Debug.Log("NOT FOUND FILE");
            }
        }
}
