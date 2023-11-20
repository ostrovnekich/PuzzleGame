using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{
    public string targetSceneName; // Имя целевой сцены для переключения

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Загружаем целевую сцену по её имени
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
