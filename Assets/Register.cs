using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Register : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TMP_InputField confirmPasswordInput;
    public Button registerButton;

    void Start()
    {
        registerButton.interactable = false;

        registerButton.onClick.AddListener(() =>
        {
            if (confirmPasswordInput.text != passwordInput.text) Debug.Log("Passwords do not match.");
            else StartCoroutine(Main.instance.web.Register(usernameInput.text, passwordInput.text));
        });
    }

    void Update()
    {
        registerButton.interactable = (usernameInput.text.Length >= 4 && passwordInput.text.Length >= 4 && confirmPasswordInput.text.Length >= 4);
    }
}
