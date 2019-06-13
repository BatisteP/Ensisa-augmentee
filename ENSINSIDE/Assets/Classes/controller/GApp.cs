using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GApp : MonoBehaviour
{
    public void LoadScene(string sceneName) {
        Application.LoadLevel(sceneName);
    }

    public static void ChangeScene(string sceneName) {
        Application.LoadLevel(sceneName);
    }

    public static void SetPrefUser(string firstname, string lastname, string email, string password, string status, string promo, string td, string tp, string date) {
        PlayerPrefs.SetString("firstname", firstname);
        PlayerPrefs.SetString("lastname", lastname);
        PlayerPrefs.SetString("email", email);
        PlayerPrefs.SetString("password", password);
        PlayerPrefs.SetString("status", status);
        PlayerPrefs.SetString("promo", promo);
        PlayerPrefs.SetString("td", td);
        PlayerPrefs.SetString("tp", tp);
        PlayerPrefs.SetString("today", "2019-02-11"); // date
    }
}
