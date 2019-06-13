using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promo
{
    private int id;
	private int year;
	private string specialty;
	private ArrayList students;
	
	
	public Promo(int id, int year, string specialty) {
        this.id = id;
		this.year = year;
		this.specialty = specialty;
		this.students = new ArrayList();
	}


    public int Id {
        get {
            return this.id;
        }
        set {
            this.id = value;
        }
    }

    public int Year {
        get {
            return this.year;
        }
        set {
            this.year = value;
        }
    }

    public string Specialty {
        get {
            return this.specialty;
        }
        set {
            this.specialty = value;
        }
    }

    public ArrayList Students {
        get {
            return this.students;
        }
        set {
            this.students = value;
        }
    }


    public void addStudent(Student s) {
        this.students.Add(s);
    }

    public bool containStudent(Student student)
	{
        return this.students.Contains(student);
	}

   
    public override string ToString() {
        return this.year + "A " + this.specialty;
    }
}
