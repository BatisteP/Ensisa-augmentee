using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class LSI : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] vb;

    // Start is called before the first frame update
    void Start()
    {
        vb = GetComponentsInChildren<VirtualButtonBehaviour>();
        foreach (VirtualButtonBehaviour v in vb)
        {
            v.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        PlayerPrefs.SetString("RoomName", "LSI");
        switch (vb.name) {
            case "Infos":
                Application.LoadLevel("RoomInfoScene");
                break;
            case "EDT":
                Application.LoadLevel("RoomProgramScene");
                break;
        }
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
    }
}
