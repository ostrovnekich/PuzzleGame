using UnityEngine;
using UnityEngine.SceneManagement;

public class A : MonoBehaviour
{
    public string targetSceneName = "LVL2"; // Имя целевой сцены для переключения

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Загружаем целевую сцену по её имени
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
