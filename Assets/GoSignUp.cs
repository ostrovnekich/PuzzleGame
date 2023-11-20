using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoSignUp : MonoBehaviour
{
    public string targetSceneName;

    public void SignUp()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
