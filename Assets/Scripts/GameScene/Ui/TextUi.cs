using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextUi : MonoBehaviour
{
    public Text coinCount;
    public Text platformCount;
    public Text totalCoin;
    public Text bestFloor;

    public SaveLoadData saveData;

    private void Awake()
    {
        saveData.LoadGame();
    }
    private void Update()
    {
        coinCount.text = " " + CountManager.Instance.coinCount;
        platformCount.text = " " + CountManager.Instance.platformCount;
        totalCoin.text = " " + CountManager.Instance.coinBank;
        bestFloor.text = " " + CountManager.Instance.bestPlatformScore;
    }
}
