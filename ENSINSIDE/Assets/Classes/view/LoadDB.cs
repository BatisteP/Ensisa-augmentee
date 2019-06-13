using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using UnityEditor;
using System;

public class LoadDB : MonoBehaviour
{
    void Start() {
        DBCommands.OpenDBConnection();

        GPromo.RetrievePromos();
        GRoom.RetrieveRooms();
        GUser.RetrieveUsers();
        GLesson.RetrieveLessons();
    }
}
