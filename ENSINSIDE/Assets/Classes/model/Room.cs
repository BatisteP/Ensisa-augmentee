using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Room
{

    private int roomId;
    private int floor;
	private string appelation;
	private string type;
	private int nPlaces;
	private int nPCs;
	
	
	public Room(int roomId, int floor, string appelation, string type, int nPlaces, int nPCs) {
        this.roomId = roomId;
        this.floor = floor;
        this.appelation = appelation;
        this.type = type;
        this.nPlaces = nPlaces;
        this.nPCs = nPCs;
	}


    public int RoomId {
        get {
            return this.roomId;
        }
        set {
            this.roomId = value;
        }
    }

    public int Floor {
        get {
            return this.floor;
        }
        set {
            this.floor = value;
        }
    }

    public string Appelation {
        get {
            return this.appelation;
        }
        set {
            this.appelation = value;
        }
    }

    public string Type {
        get {
            return this.type;
        }
        set {
            this.type = value;
        }
    }

    public int NPlaces {
        get {
            return this.nPlaces;
        }
        set {
            this.nPlaces = value;
        }
    }

    public int NPCs {
        get {
            return this.nPCs;
        }
        set {
            this.nPCs = value;
        }
    }


    public bool Equals(Room room) {
        return room != null
            && this.roomId == room.RoomId
            && this.floor == room.Floor
            && String.Equals(this.appelation, room.Appelation) 
            && String.Equals(this.type, room.Type)
            && this.NPlaces == room.NPlaces
            && this.nPCs == room.NPCs;
    }


    public override string ToString() {
        return this.appelation;
    }
}
