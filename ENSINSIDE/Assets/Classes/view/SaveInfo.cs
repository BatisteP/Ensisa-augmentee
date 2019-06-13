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
                int id = DBCommands.InsertTeacher(lastname.text, firstname.text, email.text, password.text);
                currentUser = GUser.CreateTeacher(id, firstname.text, lastname.text, email.text, password.text);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Prof.", "", "", "", "2019-02-11");
            }
            // Student
            else {
                Promo p = GPromo.GetPromo(1, promo.captionText.text);
                int id = DBCommands.InsertStudent(firstname.text, lastname.text, p.Id, email.text, password.text);
                currentUser = GUser.CreateStudent(id, firstname.text, lastname.text, email.text, password.text, p);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Elève", p.Specialty, td.captionText.text, tp.captionText.text, "2019-02-11");
            }

            GApp.ChangeScene(nextScene);
        }
    }


    public void UpdateUser() {
        if (!String.IsNullOrEmpty(firstname.text) && !String.IsNullOrEmpty(lastname.text) && !String.IsNullOrEmpty(email.text) && !String.IsNullOrEmpty(password.text)) {
            User currentUser = GUser.GetUserByConnexion(email.text, password.text);

            // Prof
            if (String.Equals(status.captionText.text, "Prof.")) {
                GUser.UpdateTeacher((Teacher) currentUser, firstname.text, lastname.text, email.text, password.text);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Prof.", "", "", "", "2019-02-11");
            }
            // Student
            else {
                GUser.UpdateStudent((Student) currentUser, firstname.text, lastname.text, email.text, password.text, ((Student) currentUser).Promo);
                GApp.SetPrefUser(firstname.text, lastname.text, email.text, password.text, "Elève", promo.captionText.text, td.captionText.text, tp.captionText.text, "2019-02-11");
            }

            GApp.ChangeScene(nextScene);
        }
    }
}
