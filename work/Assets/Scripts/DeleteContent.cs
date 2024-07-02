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
        // Получаем все дочерние объекты contentPanel
        Button[] buttons = contentPanel.GetComponentsInChildren<Button>();

        // Проходим по всем кнопкам и добавляем обработчик нажатия
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => DeleteObject(button.gameObject));
        }
    }

    void DeleteObject(GameObject objToDelete)
    {
        Destroy(objToDelete);

        // Перестройка расположения оставшихся элементов в Scroll Rect
        LayoutRebuilder.ForceRebuildLayoutImmediate(contentPanel.GetComponent<RectTransform>());
        Canvas.ForceUpdateCanvases();
    }
}
