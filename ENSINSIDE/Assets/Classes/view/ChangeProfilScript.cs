using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChangeProfilScript : MonoBehaviour
{
    public InputField firstname;
    public InputField lastname;
    public Dropdown status;
    public Dropdown promo;
    public Dropdown td;
    public Dropdown tp;
    public InputField email;
    public InputField psw;


    void Start() {
        firstname.text = PlayerPrefs.GetString("firstname");
        lastname.text = PlayerPrefs.GetString("lastname");
        status.captionText.text = PlayerPrefs.GetString("status");
        promo.captionText.text = PlayerPrefs.GetString("promo");
        td.captionText.text = PlayerPrefs.GetString("td");
        tp.captionText.text = PlayerPrefs.GetString("tp");
        email.text = PlayerPrefs.GetString("email");
        psw.text = PlayerPrefs.GetString("password");
    }
}
