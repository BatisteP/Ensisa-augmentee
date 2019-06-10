using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SaveInfo : MonoBehaviour
{
    public InputField firstname;
    public InputField lastname;
    public InputField email;
    public InputField password;
    public Dropdown status;
    public Dropdown promo;
    public Dropdown td;
    public Dropdown tp;

    public String nextScene;

    public void saveInfo() {
        if (!String.IsNullOrEmpty(firstname.text) && !String.IsNullOrEmpty(lastname.text) && !String.IsNullOrEmpty(email.text) && !String.IsNullOrEmpty(password.text)) {
            // Prof
            if (status.value == 1) {

            }
            // Student
            else {

            }

            PlayerPrefs.SetString("email", email.text);
            PlayerPrefs.SetString("password", password.text);
            changeScene(nextScene);
        }
    }

    public void changeScene(string sceneName) {
        Application.LoadLevel(sceneName);
    }
}
