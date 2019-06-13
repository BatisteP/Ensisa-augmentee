using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNavigation : MonoBehaviour {

    public static void GoTo() {
        Node dest = Navigation.searchNode(PlayerPrefs.GetString("RoomName"));
        if (dest != null) {
            Navigation.isNavigating = true;
            Navigation.destination = dest;
        }
    }
}
