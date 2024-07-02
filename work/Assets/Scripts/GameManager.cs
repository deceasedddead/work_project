using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public RectTransform gamePanel;

    [SerializeField] public RectTransform settingsPanel;

    void Start()
    {
        //��������� ������ ��� ������ ����
        gamePanel.gameObject.SetActive(false);
        settingsPanel.gameObject.SetActive(false);
    }

    //������ ��� ������ ���������
    public void SettingsCloseButton()
    {
        settingsPanel.gameObject.SetActive(false);
    }

    public void SettingsOpenButton()
    {
        settingsPanel.gameObject.SetActive(true);
    }

    //������ ��� ������ ����
    public void GameOpenButton()
    {
        gamePanel.gameObject.SetActive(true);
    }

    public void GameCloseButton() 
    {
        gamePanel.gameObject.SetActive(false);
    }
}
