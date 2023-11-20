using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour
{
    public string targetSceneName; // ��� ������� ����� ��� ������������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ��������� ������� ����� �� � �����
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
