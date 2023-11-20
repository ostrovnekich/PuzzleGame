using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public string targetSceneName;

    public string targetSceneName2;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(targetSceneName);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(targetSceneName2);
        }
    }
}
