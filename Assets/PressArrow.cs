using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressArrow : MonoBehaviour
{
    public string targetSceneName;

    public void SelectLVL()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
