using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackMenu : MonoBehaviour
{
    public string targetSceneName;

    public void Back()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
