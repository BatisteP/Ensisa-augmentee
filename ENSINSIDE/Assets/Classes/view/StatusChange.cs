using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusChange : MonoBehaviour {

    public Dropdown status;
    public Dropdown promo;
    public Dropdown td;
    public Dropdown tp;

    public void selection() {
        if(status.value == 1) {
            promo.gameObject.SetActive(false);
            td.gameObject.SetActive(false);
            tp.gameObject.SetActive(false);
            Debug.Log("prof");
        }
        else {
            promo.gameObject.SetActive(true);
            td.gameObject.SetActive(true);
            tp.gameObject.SetActive(true);
            Debug.Log("eleve");
        }
    }
}
