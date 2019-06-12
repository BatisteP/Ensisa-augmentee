using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GLesson : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(this);
    }

    private static List<Lesson> lessons = new List<Lesson>();
    private static int lastId = -1;


    // TODO: Busra CreateLesson BDD + recupérer id
    public static Lesson CreateLesson(Room room, DateTime start, int duration, Teacher teacher, Promo promo) {
        Lesson lesson = new Lesson(lastId, room, start, duration, teacher, promo);
        lessons.Add(lesson);

        return lesson;
    }


    public static Lesson GetLesson(Room room, DateTime start) {
        Lesson lesson = null;

        foreach(Lesson l in lessons) {
            if(l.Room.Equals(room) && l.Start.Equals(start)) {
                lesson = l;
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
