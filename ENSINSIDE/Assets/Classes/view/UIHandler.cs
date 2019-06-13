using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour
{
    public Image nav;

    public Button profil;
    public Button deconnexion;
    public Button findRoom;
    public Button findSomeone;

    public Button menu;

    public void navStart()
    {
        if(!nav.gameObject.active)
        {
            nav.gameObject.SetActive(true);
            StartCoroutine(startSlide(0.2f));
        }
        else
        {
            profil.GetComponentInChildren<Text>().text = "";
            deconnexion.GetComponentInChildren<Text>().text = "";
            findRoom.GetComponentInChildren<Text>().text = "";
            findSomeone.GetComponentInChildren<Text>().text = "";
            menu.GetComponentInChildren<Text>().text = "+";

            StartCoroutine(startSlide(-0.2f));
        }
        
    }

    IEnumerator startSlide(float coeff)
    {
        yield return new WaitForSeconds(0.01f);
        nav.fillAmount = nav.fillAmount + coeff;
        profil.GetComponentInChildren<Image>().fillAmount = profil.GetComponentInChildren<Image>().fillAmount + coeff;
        deconnexion.GetComponentInChildren<Image>().fillAmount = deconnexion.GetComponentInChildren<Image>().fillAmount + coeff;
        findRoom.GetComponentInChildren<Image>().fillAmount = findRoom.GetComponentInChildren<Image>().fillAmount + coeff;
        findSomeone.GetComponentInChildren<Image>().fillAmount = findSomeone.GetComponentInChildren<Image>().fillAmount + coeff;

        if (nav.fillAmount < 1 && nav.fillAmount > 0)
        {
            StartCoroutine(startSlide(coeff));
        }
        else if (nav.fillAmount == 0)
        {
            nav.gameObject.SetActive(false);
        }
        else if (nav.fillAmount == 1)
        {
            profil.GetComponentInChildren<Text>().text = "Profil";
            deconnexion.GetComponentInChildren<Text>().text = "Déconnexion";
            findRoom.GetComponentInChildren<Text>().text = "Rechercher une salle";
            findSomeone.GetComponentInChildren<Text>().text = "Rechercher quelqu'un";
            menu.GetComponentInChildren<Text>().text = "-";
        }
    }
}
