using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonImage : MonoBehaviour
{
    public Button button; // Ссылка на компонент кнопки
    public Sprite image1; // Первое изображение
    public Sprite image2; // Второе изображение

    private bool isImage1 = true; // Флаг для отслеживания текущего изображения

    private Image buttonImage; // Ссылка на компонент Image кнопки

    private void Start()
    {
        
    }

    public void ToggleImage()
    {
        if (buttonImage != null && image1 != null && image2 != null)
        {
            // Переключаем между изображениями
            if (isImage1)
            {
                buttonImage.sprite = image2;
            }
            else
            {
                buttonImage.sprite = image1;
            }

            isImage1 = !isImage1; // Инвертируем флаг состояния
        }
    }
    private void OnClick()
    {
        button.interactable = false;
        // Выполнение нужной функции
        button.interactable = true;
    }
}
