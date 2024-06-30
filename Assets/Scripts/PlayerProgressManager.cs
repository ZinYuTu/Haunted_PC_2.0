/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgressManager : MonoBehaviour
{
    public static void SavePlayerProgress(PlayerData playerData)
    {
        PlayerPrefs.SetString("UpgradeCost", playerData.upgradeCost);
        PlayerPrefs.SetInt("Score", playerData.scoreText);
        PlayerPrefs.SetInt("UpgradeAutoClickCost", playerData.upgradeAutoClickCost);

        for (int i = 0; i < playerData.achievements.Length; i++)
        {
            PlayerPrefs.SetString("Achievement_" + i, playerData.achievements[i]);
        }

        PlayerPrefs.Save();
    }

    public static PlayerData LoadPlayerProgress()
    {
        PlayerData playerData = new PlayerData();
        playerData.upgradeCost = PlayerPrefs.GetString("UpgradeCost", 0);
        playerData.scoreText = PlayerPrefs.GetInt("Score", 0);
        playerData.upgradeAutoClickCost = PlayerPrefs.GetInt("UpgradeAutoClickCost", 0);

        for (int i = 0; i < playerData.achievements.Length; i++)
        {
            playerData.achievements[i] = PlayerPrefs.GetString("Achievement_" + i, "");
        }

        return playerData;
    }
}

public class PlayerData
{
    public string upgradeCost;
    public int scoreText;
    public int upgradeAutoClickCost;
    public string[] achievements = new string[3]; // Пример: 3 достижения
}*/


