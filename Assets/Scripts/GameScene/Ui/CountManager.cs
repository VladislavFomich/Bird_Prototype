using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountManager : Singleton<CountManager>
{
    public int platformCount;
    public int coinCount;
    public int bestPlatformScore;
    public int coinBank;

    public GameObject losepanel;
    public GenerateColliders generate;

    private void Start()
    {
        Time.timeScale = 1;
        coinBank = SaveLoadData.Instance.coinBank;
        bestPlatformScore = SaveLoadData.Instance.bestFloor;            
    }
}
