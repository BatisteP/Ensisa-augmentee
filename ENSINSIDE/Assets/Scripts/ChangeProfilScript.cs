using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChangeProfilScript : MonoBehaviour
{
    public InputField firstname;
    public InputField lastname;
    public Dropdown statut;
    public Dropdown promo;
    public Dropdown td;
    public Dropdown tp;
    public InputField email;
    public InputField psw;

    // Start is called before the first frame update
    void Start()
    {
        firstname.text = "Manon";
        lastname.text = "Heyser";
        statut.value = 0;
        promo.value = 0;
        td.value = 1;
        tp.value = 1;
        email.text = "manon.heyser@uha.fr";
        psw.text = "141298";
    }
}
