using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuUi : MonoBehaviour
{
    public Button startGame;
    public Button shop;
    public Button info;
    public Button sound;
    public Button backFromInfo;
    public Button backFromShop;

    private GameObject backMusic;
    bool isSound = true;

    public GameObject infoPanel;
    public GameObject shopPanel;
    private void Start()
    {
        Time.timeScale = 1;
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Music");
        backMusic = obj[0];
        startGame.onClick.AddListener(StartGameScene);
        sound.onClick.AddListener(ClickMusic);
        info.onClick.AddListener(InfoPanelStart);
        backFromInfo.onClick.AddListener(BacktoMenuFromInfo);
        shop.onClick.AddListener(ShopPanelStart);
        backFromShop.onClick.AddListener(BacktoMenuFromInfo);
    }

    private void StartGameScene() => SceneManager.LoadScene(1);
    private void ClickMusic()
    {
        if (isSound)
        {
            isSound = false;
            backMusic.SetActive(false);
        }
        else
        {
            isSound = true;
            backMusic.SetActive(true);
        }
    }
    private void InfoPanelStart() => infoPanel.SetActive(true);

    private void BacktoMenuFromInfo()
    {
        infoPanel.SetActive(false);
        shopPanel.SetActive(false);
    }
    private void ShopPanelStart() => shopPanel.SetActive(true);
}
