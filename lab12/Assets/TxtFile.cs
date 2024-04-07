using UnityEngine;
using System.IO;

public class TxtFile : MonoBehaviour
{
    // Setup File Path 
    string FilePath;

    // String for File Content
    string TextFileContent = "You have properly created a text file for the player data such as name and date! \n\n";

    // String to Append
    string AppendText = "\n You have appended this as well!";

    void Awake()
    {
       WriteFile();
    }

    void WriteFile()
    {
        FilePath = Application.dataPath + "/Text_File_Example.txt";

        if (!File.Exists(FilePath))
        {
            File.WriteAllText(FilePath, TextFileContent);
        }

        // Append to Existing File
        File.AppendAllText(FilePath, AppendText);

    }
}