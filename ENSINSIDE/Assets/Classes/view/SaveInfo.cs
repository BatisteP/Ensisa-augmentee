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

    // Check si modification ou nouvel utilisateur
    public void CreateUser() {
        if (!String.IsNullOrEmpty(firstname.text) && !String.IsNullOrEmpty(lastname.text) && !String.IsNullOrEmpty(email.text) && !String.IsNullOrEmpty(password.text)) {
            User currentUser;
            
            // Prof
            if (String.Equals(status.captionText.text, "Prof.")) {
                currentUser = GUser.CreateTeacher(firstname.text, lastname.text, email.text, password.text);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Prof.", "", "", "", "2019-02-14");
            }
            // Student
            else {
                Debug.Log(status.captionText.text);
                currentUser = GUser.CreateStudent(firstname.text, lastname.text, email.text, password.text, null);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Elève", promo.captionText.text, td.captionText.text, tp.captionText.text, "2019-02-14");
            }

            GApp.ChangeScene(nextScene);
        }
    }


    public void UpdateUser() {
        if (!String.IsNullOrEmpty(firstname.text) && !String.IsNullOrEmpty(lastname.text) && !String.IsNullOrEmpty(email.text) && !String.IsNullOrEmpty(password.text)) {
            User currentUser = GUser.GetUserByConnexion(firstname.text, lastname.text);
            if (currentUser == null) Debug.Log("\tnull");
            // Prof
            if (String.Equals(status.captionText.text, "Prof.")) {
                GUser.UpdateTeacher((Teacher) currentUser, firstname.text, lastname.text, email.text, password.text);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Prof.", "", "", "", "2019-02-14");
            }
            // Student
            else {
                GUser.UpdateStudent((Student) currentUser, firstname.text, lastname.text, email.text, password.text, null);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Elève", promo.captionText.text, td.captionText.text, tp.captionText.text, "2019-02-14");
            }

            GApp.ChangeScene(nextScene);
        }
    }
}
