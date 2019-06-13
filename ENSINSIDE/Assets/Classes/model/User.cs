using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class User
{
    private int id;
    private string firstname;
    private string lastname;
    private string email;
    private string password;


    public User(int id, string firstname, string lastname, string email, string password) {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.password = password;
    }


    public int Id {
        get {
            return this.id;
        }
        set {
            this.id = value;
        }
    }

    public string Firstname {
        get {
            return this.firstname;
        }
        set {
            this.firstname = value;
        }
    }

    public string Lastname {
        get {
            return this.lastname;
        }
        set {
            this.lastname = value;
        }
    }

    public string Email {
        get {
            return this.email;
        }
        set {
            this.email = value;
        }
    }

    public string Password {
        get {
            return this.password;
        }
        set {
            this.password = value;
        }
    }


    public abstract bool IsStudent();


    public override string ToString() {
        return this.firstname + " " + this.lastname;
    }
}
