using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WASD : Player
{
    public void ChangeControl()
    {
        check = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
