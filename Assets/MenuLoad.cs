using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoad : MonoBehaviour
{
    public string targetSceneName;

    public void StartMenu()
    {
        SceneManager.LoadScene(targetSceneName);
    }

}
