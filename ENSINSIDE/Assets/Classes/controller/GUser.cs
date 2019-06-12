using System;
using System.Collections.Generic;
using UnityEngine;

public class GUser : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(this);
    }

    private static List<User> users = new List<User>();
    private static int lastId = -1;


    public static List<User> Users() {
        return users;
    }


    public static List<string> UsersName() {
        List<string> usersName = new List<string>();

        foreach (User user in users) {
            usersName.Add(user.ToString());
        }

        return usersName;
    }


    // TODO: Busra CreateStudent BDD + recupérer id
    public static Student CreateStudent (string firstname, string lastname, string email, string password, Promo promo) {
        Student student = new Student(lastId, firstname, lastname, email, password, promo);
        users.Add(student);
        Debug.Log("count: " + users.Count);
        return student;
    }

    // TODO: Busra CreateTeacher BDD + recupérer id
    public static Teacher CreateTeacher (string firstname, string lastname, string email, string password) {
        Teacher teacher = new Teacher(lastId, firstname, lastname, email, password);
        users.Add(teacher);

        return teacher;
    }


    public static User GetUserByName (string firstname, string lastname) {
        User user = null;

        foreach(User u in users) {
            if(String.Equals(u.Firstname, firstname) && String.Equals(u.Lastname, lastname)) {
                user =  u;
            }
        }

        return user;
    }

    public static User GetUser (int id) {
        User user = null;

        foreach (User u in users) {
            if (user.Id == id) {
                user = u;
            }
        }

        return user;
    }

    public static User GetUserByConnexion (string email, string password) {
        User user = null;

        foreach (User u in users) {
            if (String.Equals(u.Email, email) && String.Equals(u.Password, password)) {
                user = u;
            }
        }

        Debug.Log(users.Count);
        if (users.Count > 0) Debug.Log(users[0]);

        return user;
    }

    // TODO: Busra UpdateStudent BDD
    public static void UpdateStudent (Student student, string firstname, string lastname, string email, string password, Promo promo) {
        student.Firstname = firstname;
        student.Lastname = lastname;
        student.Email = email;
        student.Password = password;
        student.Promo = promo;
    }

    // TODO: Busra UpdateTeacher BDD
    public static void UpdateTeacher (Teacher teacher, string firstname, string lastname, string email, string password) {
        teacher.Firstname = firstname;
        teacher.Lastname = lastname;
        teacher.Email = email;
        teacher.Password = password;
    }
}
