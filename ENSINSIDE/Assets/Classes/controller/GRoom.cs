using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRoom : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(this);
    }

    private static List<Room> rooms = new List<Room>();
    private static int lastId = -1;


    public static List<Room> Rromos() {
        return rooms;
    }


    public static List<string> RoomsName() {
        List<string> roomsName = new List<string>();

        foreach (Room room in rooms) {
            roomsName.Add(room.ToString());
        }

        return roomsName;
    }



    // TODO: Busra CreateRoom BDD + recupérer id
    public static Room CreateRoom(int roomId, int floor, string appelation, string type, int nPlaces, int nPCs) {
        Room room = new Room(roomId, floor, appelation, type, nPlaces, nPCs);
        rooms.Add(room);

        return room;
    }


    public static Room GetRoom(string appelation) {
        Room room = null;

        foreach (Room r in rooms) {
            if (string.Equals(r.Appelation, appelation)) {
                room = r;
            }
        }

        return room;
    }

    public static Room GetRoom(int roomId, int floor) {
        Room room = null;

        foreach (Room r in rooms) {
            if (r.RoomId == roomId && r.Floor == floor) {
                room = r;
            }
        }

        return room;
    }
}
