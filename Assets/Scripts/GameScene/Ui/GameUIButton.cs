using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIButton : MonoBehaviour
{
    public Button repeatLevel;
    public Button shop;
    public Button home;
    public Button rate;
    

    public GameObject shopPanel;
    public GameObject ratePanel;

    public Button backFromShop;
    public Button backFromRate;
    private void Start()
    {
        repeatLevel.onClick.AddListener(StartGameLevel);
        shop.onClick.AddListener(OpenShopPanel);
        home.onClick.AddListener(StartHomeLevel);
        rate.onClick.AddListener(OpenRatePanel);
        backFromRate.onClick.AddListener(BackToLoseMenu);
        backFromShop.onClick.AddListener(BackToLoseMenu);
    }

    private void StartGameLevel()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(1);
    }
    private void StartHomeLevel() => SceneManager.LoadScene(0);
    private void OpenShopPanel() => shopPanel.SetActive(true);
    private void OpenRatePanel() => ratePanel.SetActive(true);
    private void BackToLoseMenu()
    {
        shopPanel.SetActive(false);
        ratePanel.SetActive(false);
    }
}