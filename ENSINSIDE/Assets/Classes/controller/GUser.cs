using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using UnityEditor;
using System;

public class GUser
{
    public static List<User> users = new List<User>();

    public static Student student = null;
    public static Teacher teacher = null;
    public static User user = null;
    public static List<string> usersName = new List<string>();


    public static List<User> Users() {
        return users;
    }


    public static List<string> UsersName() {
        foreach (User user in users) {
            usersName.Add(user.ToString());
        }

        return usersName;
    }

    public static void RetrieveUsers() {
        IDataReader reader = DBCommands.RetrieveUsers();

        while (reader.Read()) {
            int id = Int32.Parse(reader[0].ToString());
            string firstname = reader[1].ToString();
            string lastname = reader[2].ToString();
            string email = reader[3].ToString();
            string password = reader[4].ToString();

            IDataReader userReader = DBCommands.RetrieveStudentPromo(email, password);
            if (userReader != null) {
                userReader.Read();
                int idPromo = Int32.Parse(userReader[0].ToString());

                CreateStudent(id, firstname, lastname, email, password, GPromo.GetPromo(idPromo));
            }
            else {
                CreateTeacher(id, firstname, lastname, email, password);
            }
        }
    }


    // TODO: Busra CreateStudent BDD + recupérer id
    public static Student CreateStudent (int id, string firstname, string lastname, string email, string password, Promo promo) {
        student = new Student(id, firstname, lastname, email, password, promo);
        users.Add(student);

        return student;
    }

    // TODO: Busra CreateTeacher BDD + recupérer id
    public static Teacher CreateTeacher (int id, string firstname, string lastname, string email, string password) {
        teacher = new Teacher(id, firstname, lastname, email, password);
        users.Add(teacher);

        return teacher;
    }


    public static User GetUserByName (string firstname, string lastname) {       

        foreach(User u in users) {
            if(String.Equals(u.Firstname, firstname) && String.Equals(u.Lastname, lastname)) {
                user = u;
            }
        }

        return user;
    }

    public static User GetUser (int id) {
        foreach (User u in users) {
            if (u.Id == id) {
                user = u;
            }
        }

        return user;
    }

    public static User GetUserByConnexion (string email, string password) {
        foreach (User u in users) {
            if (String.Equals(u.Email, email) && String.Equals(u.Password, password)) {
                user = u;
            }
        }

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
