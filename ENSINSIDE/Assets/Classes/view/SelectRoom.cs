using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectRoom : MonoBehaviour
{
    public Dropdown roomDD;

    public void ChangeRoom() {
        PlayerPrefs.SetString("RoomName", roomDD.captionText.text);
    }
}
