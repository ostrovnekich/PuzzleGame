using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public string targetSceneName;

    public void RunMenu()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
