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
    public Text thursday810;
    public Text thursday1012;
    public Text thursday1214;
    public Text thursday1416;
    public Text thursday1618;
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
            Room room = GRoom.GetRoom(PlayerPrefs.GetString("RoomName"));

            if (room != null) {
                roomText.text = room.Appelation;

                // PlayerPrefs.SetString("today", date);  "2019-02-11"
                /*int year = Int32.Parse(PlayerPrefs.GetString("today").Split('-')[0]);
                int month = Int32.Parse(PlayerPrefs.GetString("today").Split('-')[1]);
                int day = Int32.Parse(PlayerPrefs.GetString("today").Split('-')[2]);*/

                display(new DateTime(2019, 02, 11, 8, 0, 0), room,  monday810);
                display(new DateTime(2019, 02, 11, 10, 0, 0), room, monday1012);
                display(new DateTime(2019, 02, 11, 12, 0, 0), room, monday1214);
                display(new DateTime(2019, 02, 11, 14, 0, 0), room, monday1416);
                display(new DateTime(2019, 02, 11, 16, 0, 0), room, monday1618);

                display(new DateTime(2019, 02, 12, 8, 0, 0), room,  tuesday810);
                display(new DateTime(2019, 02, 12, 10, 0, 0), room, tuesday1012);
                display(new DateTime(2019, 02, 12, 12, 0, 0), room, tuesday1214);
                display(new DateTime(2019, 02, 12, 14, 0, 0), room, tuesday1416);
                display(new DateTime(2019, 02, 12, 16, 0, 0), room, tuesday1618);

                display(new DateTime(2019, 02, 13, 8, 0, 0), room,  wednesday810);
                display(new DateTime(2019, 02, 13, 10, 0, 0), room, wednesday1012);
                display(new DateTime(2019, 02, 13, 12, 0, 0), room, wednesday1214);
                display(new DateTime(2019, 02, 13, 14, 0, 0), room, wednesday1416);
                display(new DateTime(2019, 02, 13, 16, 0, 0), room, wednesday1618);

                display(new DateTime(2019, 02, 14, 8, 0, 0), room,  thursday810);
                display(new DateTime(2019, 02, 14, 10, 0, 0), room, thursday1012);
                display(new DateTime(2019, 02, 14, 12, 0, 0), room, thursday1214);
                display(new DateTime(2019, 02, 14, 14, 0, 0), room, thursday1416);
                display(new DateTime(2019, 02, 14, 16, 0, 0), room, thursday1618);

                display(new DateTime(2019, 02, 15, 8, 0, 0), room,  friday810);
                display(new DateTime(2019, 02, 15, 10, 0, 0), room, friday1012);
                display(new DateTime(2019, 02, 15, 12, 0, 0), room, friday1214);
                display(new DateTime(2019, 02, 15, 14, 0, 0), room, friday1416);
                display(new DateTime(2019, 02, 15, 16, 0, 0), room, friday1618);

                weekText.text = "Sem. du " + PlayerPrefs.GetString("today");
            }
        }
    }
    
    private void display(DateTime date, Room room, Text text) {
        Lesson lesson = GLesson.GetLesson(room, date);
        text.text = lesson.Description + "\n" + lesson.Promo.Specialty + "\n" + lesson.Teacher.Firstname + " " + lesson.Teacher.Lastname;
    }
}
