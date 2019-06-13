using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRooms : MonoBehaviour
{
    public Dropdown rooms;

    void Start() {
        rooms.AddOptions(GRoom.RoomsName());
    }
}
