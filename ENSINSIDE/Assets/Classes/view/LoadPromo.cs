using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPromo : MonoBehaviour
{
    public Dropdown promo;

    void Start() {        
        promo.AddOptions(GPromo.PromosName());
    }
}
