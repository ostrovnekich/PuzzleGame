using UnityEngine;
using UnityEngine.SceneManagement;

public class A : MonoBehaviour
{
    public string targetSceneName = "LVL2"; // ��� ������� ����� ��� ������������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ��������� ������� ����� �� � �����
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
