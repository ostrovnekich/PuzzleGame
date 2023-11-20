using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Web : MonoBehaviour
{
    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        UnityWebRequest www = UnityWebRequest.Post("http://localhost/game/Login.php", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            string serverResponse = www.downloadHandler.text;

            if (www.downloadHandler.text.Contains("Login success."))
            {
                SceneManager.LoadScene("MainMenu");

                DBManager.username = username;
            }

        }
    }

    public IEnumerator Register(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        UnityWebRequest www = UnityWebRequest.Post("http://localhost/game/Register.php", form);
        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            string serverResponse = www.downloadHandler.text;

            if (serverResponse.Contains("New record created successfully"))
            {
                SceneManager.LoadScene("MainMenu");

                DBManager.username = username;


            }
        }
    }
}
