using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : User
{
    public Teacher(int id, string firstname, string lastname, string email, string password) : base(id, firstname, lastname, email, password) {
    }


    public override bool IsStudent() {
        return false;
    }
}
