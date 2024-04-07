using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

public class XMLSaveData : MonoBehaviour
{
    string filePath;
    void Start()
    {
        // Creating and Setting File Path
        filePath = Path.Combine(Application.persistentDataPath, "playerData.xml");

        // Setting Player Data to Save
        SavePlayerData("Player1", 100);
    }

    // Save player data to XML file
    void SavePlayerData(string playerName, int playerScore)
    {
        // Create XML document
        XmlDocument xmlDoc = new XmlDocument();

        // Create root element
        XmlElement rootElement = xmlDoc.CreateElement("PlayerData");
        xmlDoc.AppendChild(rootElement);

        // Create player element
        XmlElement playerElement = xmlDoc.CreateElement("Player");
        rootElement.AppendChild(playerElement);

        // Add playerName attribute to player element
        XmlAttribute playerNameAttribute = xmlDoc.CreateAttribute("Name");
        playerNameAttribute.Value = playerName;
        playerElement.Attributes.Append(playerNameAttribute);

        // Add playerScore attribute to player element
        XmlAttribute playerScoreAttribute = xmlDoc.CreateAttribute("Score");
        playerScoreAttribute.Value = playerScore.ToString();
        playerElement.Attributes.Append(playerScoreAttribute);

        // Save XML document to file
        xmlDoc.Save(filePath);
    }
}
