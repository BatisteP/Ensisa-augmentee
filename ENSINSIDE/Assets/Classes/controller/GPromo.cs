using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using UnityEditor;
using System;

public class GPromo
{
    private static List<Promo> promos = new List<Promo>();


    public static List<Promo> Promos() {
        return promos;
    }


    public static List<string> PromosName() {
        List<string> promosName = new List<string>();

        foreach(Promo promo in promos) {
            promosName.Add(promo.ToString());
        }

        return promosName;
    }


    public static void RetrievePromos() {
        IDataReader reader = DBCommands.RetrievePromos();

        while (reader.Read()) {
            int id = Int32.Parse(reader[0].ToString());
            int year = Int32.Parse(reader[1].ToString());
            string specialty = reader[2].ToString();

            CreatePromo(id, year, specialty);
        }
    }


    // TODO: Busra CreatePromo BDD + recupérer id
    public static Promo CreatePromo(int id, int year, string specialty) {
        Promo promo = new Promo(id, year, specialty);
        promos.Add(promo);

        return promo;
    }


    public static Promo GetPromo(int year, string specialty) {
        Promo promo = null;

        foreach (Promo p in promos) {
            if (p.Year == year && String.Equals(p.Specialty, specialty)) {
                return p;
            }
        }

        return promo;
    }

    public static Promo GetPromo(int id) {
        Promo promo = null;

        foreach (Promo p in promos) {
            if (p.Id == id) {
                return p;
            }
        }

        return promo;
    }
}
