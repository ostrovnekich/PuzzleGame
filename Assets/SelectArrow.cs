using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectArrow : Player
{
    public void ChangeControl()
    {
        check = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
