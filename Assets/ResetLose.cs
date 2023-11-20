using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLose : MonoBehaviour
{
    public string targetSceneName;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}