using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadUsers : MonoBehaviour
{
    public Dropdown users;

    void Start() {
        List<string> usersName = GUser.usersName;
        usersName.Remove(PlayerPrefs.GetString("firstname") + " " + PlayerPrefs.GetString("lastname"));

        users.AddOptions(usersName);
    }
}
