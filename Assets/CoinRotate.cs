using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // ������������ ������ ��� ������� �������

            // �������� rotationSpeed �� Time.deltaTime ��� ����������� ��������
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        
    }
}
