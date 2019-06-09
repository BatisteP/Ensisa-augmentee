using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    // Start is called before the first frame update
    public void changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
        //SceneManager.LoadScene(scenename);
    }

  
}
