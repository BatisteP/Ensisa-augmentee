using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using UnityEditor;
using System;

public class GLesson
{

    private static List<Lesson> lessons = new List<Lesson>();


    public static void RetrieveLessons() {
        IDataReader reader = DBCommands.RetrieveLessons();

        while (reader.Read()) {
            int id = Int32.Parse(reader[0].ToString());
            int roomId = Int32.Parse(reader[1].ToString());
            int floor = Int32.Parse(reader[2].ToString());
            Debug.Log("date: " + reader[3].ToString().Split(' ')[0] + " " + reader[4].ToString().Split(' ')[1]);
            DateTime start = Convert.ToDateTime(reader[3].ToString().Split(' ')[0] + " " +  reader[4].ToString().Split(' ')[1]); // ????
            int duration = Int32.Parse(reader[5].ToString());
            int idPromo = Int32.Parse(reader[6].ToString());
            int idProf = Int32.Parse(reader[7].ToString());
            string description = reader[8].ToString();

            Room room = GRoom.GetRoom(roomId, floor);
            User teacher = GUser.GetUser(idProf);
            Promo promo = GPromo.GetPromo(idPromo);
            CreateLesson(id, room, start, duration, teacher, promo, description);
        }
    }


    // TODO: Busra CreateLesson BDD + recupérer id
    public static Lesson CreateLesson(int id, Room room, DateTime start, int duration, User teacher, Promo promo, string description) {
        Lesson lesson = new Lesson(id, room, start, duration, teacher, promo, description);
        lessons.Add(lesson);

        return lesson;
    }


    public static Lesson GetLesson(Room room, DateTime start) {
        Lesson lesson = null;

        foreach(Lesson l in lessons) {
            if(l.Room.Equals(room) && l.Start.Equals(start)) {
                return l;
            }
        }

        return lesson;
    }


    public static List<Lesson> GetSchedule(Room room) {
        List<Lesson> scheduledLessons = new List<Lesson>();

        foreach (Lesson lesson in lessons) {
            if (lesson.Room.Equals(room)) {
                scheduledLessons.Add(lesson);
            }
        }

        return scheduledLessons;
    }

    public static List<Lesson> GetSchedulePerWeek(Room room, DateTime date) {
        List<Lesson> scheduledLessons = new List<Lesson>();

        foreach (Lesson lesson in lessons) {
            if (lesson.Room.Equals(room) && lesson.IsSameWeek(date)) {
                scheduledLessons.Add(lesson);
            }
        }

        return scheduledLessons;
    }
}
