using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSignIn : MonoBehaviour
{
    public string targetSceneName;

    public void SignIn()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
