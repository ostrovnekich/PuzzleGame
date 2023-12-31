using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonImage : MonoBehaviour
{
    public Button button; // ������ �� ��������� ������
    public Sprite image1; // ������ �����������
    public Sprite image2; // ������ �����������

    private bool isImage1 = true; // ���� ��� ������������ �������� �����������

    private Image buttonImage; // ������ �� ��������� Image ������

    private void Start()
    {
        
    }

    public void ToggleImage()
    {
        if (buttonImage != null && image1 != null && image2 != null)
        {
            // ����������� ����� �������������
            if (isImage1)
            {
                buttonImage.sprite = image2;
            }
            else
            {
                buttonImage.sprite = image1;
            }

            isImage1 = !isImage1; // ����������� ���� ���������
        }
    }
    private void OnClick()
    {
        button.interactable = false;
        // ���������� ������ �������
        button.interactable = true;
    }
}
