using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Поворачиваем объект при нажатии клавиши

            // Умножаем rotationSpeed на Time.deltaTime для сглаживания вращения
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        
    }
}
