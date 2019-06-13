using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using UnityEditor;
using System;

public class GRoom
{

    private static List<Room> rooms = new List<Room>();
    private static int lastId = -1;


    public static List<Room> Rromos() {
        return rooms;
    }


    public static void RetrieveRooms() {
        IDataReader reader = DBCommands.RetrieveRooms();

        while (reader.Read()) {
            int roomId = Int32.Parse(reader[0].ToString());
            int floor = Int32.Parse(reader[1].ToString());
            string name = reader[2].ToString();
            string type = reader[3].ToString();
            int nPlaces = Int32.Parse(reader[4].ToString());
            int nPCs = Int32.Parse(reader[5].ToString());

            CreateRoom(roomId, floor, name,type, nPlaces, nPCs);
        }
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
                return r;
            }
        }

        return room;
    }

    public static Room GetRoom(int roomId, int floor) {
        Room room = null;

        foreach (Room r in rooms) {
            if (r.RoomId == roomId && r.Floor == floor) {
                return r;
            }
        }

        return room;
    }
}
