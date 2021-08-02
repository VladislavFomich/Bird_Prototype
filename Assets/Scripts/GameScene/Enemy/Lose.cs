using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject losePanel;

    private void Start()
    {
  
        losePanel = CountManager.Instance.losepanel;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SaveLoadData.Instance.ResetData();
            CountManager.Instance.coinBank += CountManager.Instance.coinCount;
            SaveLoadData.Instance.coinBank = CountManager.Instance.coinBank;
            if (CountManager.Instance.platformCount > CountManager.Instance.bestPlatformScore)
            {
                CountManager.Instance.bestPlatformScore = CountManager.Instance.platformCount;
                SaveLoadData.Instance.bestFloor = CountManager.Instance.bestPlatformScore;
            }
            else
                SaveLoadData.Instance.bestFloor = CountManager.Instance.bestPlatformScore;

            SaveLoadData.Instance.SaveGame();
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }
    }
}
