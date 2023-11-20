using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOne : MonoBehaviour
{
    public string targetSceneName = "LVL1";

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
