using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public RectTransform gamePanel;

    [SerializeField] public RectTransform settingsPanel;

    void Start()
    {
        //Выключаем панели при старте игры
        gamePanel.gameObject.SetActive(false);
        settingsPanel.gameObject.SetActive(false);
    }

    //Кнопки для панели настройки
    public void SettingsCloseButton()
    {
        settingsPanel.gameObject.SetActive(false);
    }

    public void SettingsOpenButton()
    {
        settingsPanel.gameObject.SetActive(true);
    }

    //кнопки для панели игры
    public void GameOpenButton()
    {
        gamePanel.gameObject.SetActive(true);
    }

    public void GameCloseButton() 
    {
        gamePanel.gameObject.SetActive(false);
    }
}
