using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONSaveData : MonoBehaviour
{
    // File path for saving player data
    string filePath;

    void Start()
    {
        // Construct the file path
        filePath = Path.Combine(Application.persistentDataPath, "playerData.json");

        // Example: Save player data
        SavePlayerData(new PlayerData { playerName = "Player1", playerHealth = 100 });
    }

    // Save player data to JSON file
    void SavePlayerData(PlayerData playerData)
    {
        string jsonData = JsonUtility.ToJson(playerData);
        File.WriteAllText(filePath, jsonData);
    }
}

class PlayerData
{
    public string playerName;
    public int playerHealth;
}
