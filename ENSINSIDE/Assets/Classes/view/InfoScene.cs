using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class InfoScene : MonoBehaviour
{
    public Text roomText;
    public Text typeText;
    public Text nbPlacesText;
    public Text nbPCsText;
    

    void Start() {
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("RoomName"))) {
            roomText.text = PlayerPrefs.GetString("RoomName");
        }   
    }
}
