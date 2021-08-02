using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadData : Singleton<SaveLoadData>
{
    public int bestFloor;
    public int coinBank;

    [Serializable]
    class SaveData
    {
        public int savedBestFloor;
        public int savedCoinBank;
    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SaveData.dat");
        SaveData data = new SaveData();
        data.savedBestFloor = bestFloor;
        data.savedCoinBank = coinBank;
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Data saved");
    }
    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();
            bestFloor = data.savedBestFloor;
            coinBank = data.savedCoinBank;
            Debug.Log("Game Loaded");
        }
        else
        {
            Debug.LogWarning("No save data");
        }
    }
    public void ResetData()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveData.dat"))
        {
            File.Delete(Application.persistentDataPath + "/SaveData.dat");
            bestFloor = 0;
            coinBank = 0;
        }
        else
            Debug.LogWarning("Data not Reset");
    }
}
