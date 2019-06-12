using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GPromo : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(this);
    }

    private static List<Promo> promos = new List<Promo>();
    private static int lastId = -1;


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

    // TODO: Busra CreatePromo BDD + recupérer id
    public static Promo CreatePromo(int year, string specialty) {
        Promo promo = new Promo(lastId, year, specialty);
        promos.Add(promo);

        return promo;
    }


    public static Promo GetPromo(int year, string specialty) {
        Promo promo = null;

        foreach (Promo p in promos) {
            if (p.Year == year && String.Equals(p.Specialty, specialty)) {
                promo = p;
            }
        }

        return promo;
    }

    
}
