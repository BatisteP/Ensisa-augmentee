using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoadProgram : MonoBehaviour
{
    public Text monday810;
    public Text monday1012;
    public Text monday1214;
    public Text monday1416;
    public Text monday1618;
    public Text tuesday810;
    public Text tuesday1012;
    public Text tuesday1214;
    public Text tuesday1416;
    public Text tuesday1618;
    public Text wednesday810;
    public Text wednesday1012;
    public Text wednesday1214;
    public Text wednesday1416;
    public Text wednesday1618;
    public Text thursay810;
    public Text thursay1012;
    public Text thursay1214;
    public Text thursay1416;
    public Text thursay1618;
    public Text friday810;
    public Text friday1012;
    public Text friday1214;
    public Text friday1416;
    public Text friday1618;

    public Text weekText;
    public Text roomText;

    public void LoadInfo() {

    }

    void Start() {
        if (!String.IsNullOrEmpty(PlayerPrefs.GetString("RoomName"))) {
            roomText.text = PlayerPrefs.GetString("RoomName");
        }
    }
    
}
