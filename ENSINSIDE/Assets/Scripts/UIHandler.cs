using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Image nav;

    public Button profil;
    public Button deconnexion;
    public Button findRoom;
    public Button findSomeone;
    public Button room;

    public void navStart()
    {
        if(!nav.gameObject.active)
        {
            nav.gameObject.SetActive(true);
            StartCoroutine(startSlide(1));
        }
        else
        {
            profil.GetComponentInChildren<Text>().text = "";
            deconnexion.GetComponentInChildren<Text>().text = "";
            findRoom.GetComponentInChildren<Text>().text = "";
            findSomeone.GetComponentInChildren<Text>().text = "";
            room.GetComponentInChildren<Text>().text = "";

            StartCoroutine(startSlide(-1));
        }
        
    }

    IEnumerator startSlide(int coeff)
    {
        yield return new WaitForSeconds(0.01f);
        nav.fillAmount = nav.fillAmount + coeff * 0.1f;
        profil.GetComponentInChildren<Image>().fillAmount = profil.GetComponentInChildren<Image>().fillAmount + coeff * 0.1f;
        deconnexion.GetComponentInChildren<Image>().fillAmount = deconnexion.GetComponentInChildren<Image>().fillAmount + coeff * 0.1f;
        findRoom.GetComponentInChildren<Image>().fillAmount = findRoom.GetComponentInChildren<Image>().fillAmount + coeff * 0.1f;
        findSomeone.GetComponentInChildren<Image>().fillAmount = findSomeone.GetComponentInChildren<Image>().fillAmount + coeff * 0.1f;
        room.GetComponentInChildren<Image>().fillAmount = room.GetComponentInChildren<Image>().fillAmount + coeff * 0.1f;

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
            room.GetComponentInChildren<Text>().text = "Salle";
        }
    }
}
