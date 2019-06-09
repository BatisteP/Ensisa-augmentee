using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class ChangeButtonColor : MonoBehaviour
{

    //Make sure to attach these Buttons in the Inspector
    public Button btnColor;

    void Start()
    {
        btnColor.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (String.Equals(btnColor.GetComponentInChildren<Text>().text, "ON"))
        {
            ColorBlock cb = btnColor.colors;
            cb.normalColor = Color.red;
            cb.highlightedColor = Color.red;
            cb.pressedColor = Color.red;
            cb.selectedColor = Color.red;
            btnColor.colors = cb;

            btnColor.GetComponentInChildren<Text>().text = "OFF";
        }
        else
        {
            ColorBlock cb = btnColor.colors;
            cb.normalColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.pressedColor = Color.green;
            cb.selectedColor = Color.green;
            btnColor.colors = cb;

            btnColor.GetComponentInChildren<Text>().text = "ON";
        }
    }
}
