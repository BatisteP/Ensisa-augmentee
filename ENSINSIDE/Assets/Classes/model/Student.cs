using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : User
{
	private Promo promo;
	
	public Student(int id, string firstname, string lastname, string email, string password, Promo promo) : base(id, firstname, lastname, email, password) {
		this.promo = promo;
	}


    public Promo Promo {
        get {
            return this.promo;
        }
        set {
            this.promo = value;
        }
    }


    public override bool IsStudent() {
        return true;
    }
}
