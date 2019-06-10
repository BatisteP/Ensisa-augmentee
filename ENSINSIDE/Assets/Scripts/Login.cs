using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Login : MonoBehaviour
{
    public InputField mailAddressIT;
    public InputField passwordIT;
    public String nextScene;

    public void login() {
        if(!String.IsNullOrEmpty(mailAddressIT.text) && !String.IsNullOrEmpty(passwordIT.text)) {
            PlayerPrefs.SetString("email", mailAddressIT.text);
            PlayerPrefs.SetString("password", passwordIT.text);
            changeScene(nextScene);
        }
    }

    public void changeScene(string sceneName) {
        Application.LoadLevel(sceneName);
    }

    public void alreadyLoggedIn() {
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("email")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("password"))) {
            changeScene(nextScene);
        }
        else {
            changeScene("ConnexionScene");  
        }
    }

    public void signOut() {
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("email")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("password"))) {
            PlayerPrefs.DeleteAll();
        }

        changeScene("ConnexionScene");
    }
}
