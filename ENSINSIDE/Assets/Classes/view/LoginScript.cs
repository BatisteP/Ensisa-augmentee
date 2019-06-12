using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoginScript : MonoBehaviour
{
    public InputField mailAddressIT;
    public InputField passwordIT;

    public void Login() {
        if(!String.IsNullOrEmpty(mailAddressIT.text) && !String.IsNullOrEmpty(passwordIT.text)) {
            GApp.SetPrefUser("Manon", "Heyser", mailAddressIT.text, passwordIT.text, "student", "IR", "TD2", "TP2", "2019-02-14"); // as IARISS didn't give us the schedule data for the current month, but for a more "full" month

           

            GApp.ChangeScene("DetectSalle");
        }
    }

    public void AlreadyLoggedIn() {

        /* Chargement base de données :
        Chargement de l'emploi du temps pour la semaine courante.
        Récupération des informations de l'utilisateur se connecte.
        */


        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("email")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("password"))) {
            GApp.ChangeScene("DetectSalle"); 
        }
        else {
            GApp.ChangeScene("ConnexionScene");  
        }
    }

    public void SignOut() {
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("email")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("password"))) {
            PlayerPrefs.DeleteAll();
        }

        GApp.ChangeScene("ConnexionScene");
    }
}
