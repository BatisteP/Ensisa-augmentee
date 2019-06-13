using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lesson {

    private int id;
    private Room room;
    private DateTime start;
    private int duration;
    private User teacher;
	private Promo promo;
	private string description;
	
	public Lesson(int id, Room room, DateTime start, int duration, User teacher, Promo promo, string description) {
        this.id = id;
        this.room = room;
        this.start = start;
        this.duration = duration;
        this.teacher = teacher;
        this.promo = promo;
        this.description = description;
	}


    public int Id {
        get {
            return this.id;
        }
        set {
            this.id = value;
        }
    }

    public Room Room {
        get {
            return this.room;
        }
        set {
            this.room = value;
        }
    }

    public DateTime Start {
        get {
            return this.start;
        }
        set {
            this.start = value;
        }
    }

    public int Duration {
        get {
            return this.duration;
        }
        set {
            this.duration = value;
        }
    }

    public User Teacher {
        get {
            return this.teacher;
        }
        set {
            this.teacher = value;
        }
    }

    public Promo Promo {
        get {
            return this.promo;
        }
        set {
            this.promo = value;
        }
    }

    public string Description {
        get {
            return this.description;
        }
        set {
            this.description = value;
        }
    }


    public bool IsActive (DateTime date)
	{
        
		if (this.start.Date == date.Date)
		{
			if (this.start.Hour < date.Hour && this.start.Hour + this.duration > date.Hour)
			{
				return true;
			}
			else if (this.start.Hour == date.Hour && this.start.Minute <= date.Minute)
			{
				return true;
			}
		}

		return false;        
	}


    public bool IsSameWeek(DateTime date) {
        return this.start.AddDays(- (int) this.start.DayOfWeek - 1) == date.AddDays(- (int) date.DayOfWeek - 1);
    }
}
