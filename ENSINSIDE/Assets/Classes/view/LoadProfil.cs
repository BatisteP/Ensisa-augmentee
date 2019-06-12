using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoadProfil : MonoBehaviour
{
    public Text nameText;
    public Text classText;
    public Text emailText;


    void Start()
    {
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("firstname")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("lastname")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("status")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("email"))) {
            nameText.text = PlayerPrefs.GetString("firstname") + " " + PlayerPrefs.GetString("lastname");
            emailText.text = PlayerPrefs.GetString("email");

            if (String.Equals(PlayerPrefs.GetString("status"), "Elève")) {
                if (!String.IsNullOrEmpty(PlayerPrefs.GetString("promo")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("td")) && !String.IsNullOrEmpty(PlayerPrefs.GetString("tp"))) {
                    classText.text = PlayerPrefs.GetString("promo") + " " + PlayerPrefs.GetString("td") + " " + PlayerPrefs.GetString("tp");
                }
            }
            else {
                classText.text = "Prof.";
            }

        }  
    }
}
