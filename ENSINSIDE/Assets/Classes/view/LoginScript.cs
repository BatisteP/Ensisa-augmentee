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
            GUser.GetUserByConnexion(mailAddressIT.text, passwordIT.text);
            User user = GUser.user;
            
            if (user != null) {
                Debug.Log("not null");
                if (user.IsStudent()) {
                    GApp.SetPrefUser(user.Firstname, user.Lastname, mailAddressIT.text, passwordIT.text, "Elève", ((Student)user).Promo.Specialty, "TD1", "TP1", "2019-02-14"); // as IARISS didn't give us the schedule data for the current month, but for a more "full" month
                }
                else {
                    GApp.SetPrefUser(user.Firstname, user.Lastname, mailAddressIT.text, passwordIT.text, "Prof.", "", "", "", "2019-02-14"); // as IARISS didn't give us the schedule data for the current month, but for a more "full" month
                }

                GApp.ChangeScene("DetectSalle");
            }

            else Debug.Log("user Null");
        }
    }

    public void AlreadyLoggedIn() {
        
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("email")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("password"))) {
            GUser.GetUserByConnexion(PlayerPrefs.GetString("email"), PlayerPrefs.GetString("password"));
            User user = GUser.user;

            if (user != null) {
                Debug.Log("not null");

                
                if (user.IsStudent()) {
                    string spe = ((Student)user).Promo.Specialty;
                    GApp.SetPrefUser(user.Firstname, user.Lastname, user.Email, user.Password, "Elève", spe, "TD1", "TP1", "2019-02-14"); // as IARISS didn't give us the schedule data for the current month, but for a more "full" month
                }
                else {
                    GApp.SetPrefUser(user.Firstname, user.Lastname, user.Email, user.Password, "Prof.", "", "", "", "2019-02-14"); // as IARISS didn't give us the schedule data for the current month, but for a more "full" month
                }

                GApp.ChangeScene("DetectSalle");
            }
            else {
                Debug.Log("user Null");
                PlayerPrefs.DeleteAll();
            }
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
