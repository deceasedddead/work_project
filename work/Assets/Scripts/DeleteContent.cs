using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteContent : MonoBehaviour
{
    public ScrollRect scrollRect;

    public GameObject contentPanel;

    void Start()
    {
        // �������� ��� �������� ������� contentPanel
        Button[] buttons = contentPanel.GetComponentsInChildren<Button>();

        // �������� �� ���� ������� � ��������� ���������� �������
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => DeleteObject(button.gameObject));
        }
    }

    void DeleteObject(GameObject objToDelete)
    {
        Destroy(objToDelete);

        // ����������� ������������ ���������� ��������� � Scroll Rect
        LayoutRebuilder.ForceRebuildLayoutImmediate(contentPanel.GetComponent<RectTransform>());
        Canvas.ForceUpdateCanvases();
    }
}
