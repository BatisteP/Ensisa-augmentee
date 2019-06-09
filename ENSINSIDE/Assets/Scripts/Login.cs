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
            changeScene(nextScene);
        }
    }

    public void changeScene(string sceneName) {
        Application.LoadLevel(sceneName);
    }
}
