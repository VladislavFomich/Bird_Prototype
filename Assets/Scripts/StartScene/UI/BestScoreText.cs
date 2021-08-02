using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BestScoreText : MonoBehaviour
{
    public Text score;
    public SaveLoadData saveData;
    private void Awake()
    {
        saveData.LoadGame();
        score.text += " " + saveData.bestFloor;
    }
}
