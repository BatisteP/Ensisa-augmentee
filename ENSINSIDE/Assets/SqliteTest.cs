using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
using UnityEditor;

public class SqliteTest : MonoBehaviour {

    static string connection;
    static IDbConnection dbcon;

    void Start() {
        connection = "URI=file:" + Application.dataPath + "/" + "database7.db";
        dbcon = new SqliteConnection(connection);
        OpenDB();


        // Insert values in table
        IDbCommand cmnd = dbcon.CreateCommand();
        cmnd.CommandText = "INSERT INTO Etudiant (id, prenom, nom, idPromo) VALUES (3, 'Benjamin', 'Chapouli', 1)";
        cmnd.ExecuteNonQuery();

        // Read and print all values in table
        IDbCommand cmnd_read = dbcon.CreateCommand();
        IDataReader reader;
        string query = "SELECT * FROM Etudiant";
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();

        while (reader.Read()) {
            Debug.Log("id: " + reader[0].ToString());
            Debug.Log("prenom: " + reader[1].ToString());
            Debug.Log("nom: " + reader[2].ToString());
        }

        // Close connection
        CloseDB();

    }

    static void OpenDB() {
        dbcon.Open();
    }

    static void CloseDB() {
        dbcon.Close();
    }
    

    void GetUser(string email, string password) {
        IDbCommand cmd = dbcon.CreateCommand();
        IDataReader reader;
        string query = "SELECT id, prenom, nom FROM Utilisateur WHERE email = @email AND mdp = @password";
        cmd.Parameters.Add(new SqliteParameter("@email", email));
        cmd.Parameters.Add(new SqliteParameter("@password", password));
        cmd.CommandText = query;
        reader = cmd.ExecuteReader();
        
    }

    void IsStudent(int idUser) {

    }
}