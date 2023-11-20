using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public Button loginButton;

    void Start()
    {
        loginButton.interactable = false;
        loginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.instance.web.Login(usernameInput.text, passwordInput.text));
        });
    }

    void Update()
    {
        loginButton.interactable = (usernameInput.text.Length >= 4 && passwordInput.text.Length >= 4);
    }
}
