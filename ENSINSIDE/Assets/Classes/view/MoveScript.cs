using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour
{
    void Update() {
        if(Input.touchCount == 1 && EventSystem.current.IsPointerOverGameObject(Input.touches[0].fingerId))
        {
            Touch touch = Input.GetTouch(0);
           
            transform.Translate(Input.touches[0].deltaPosition.x,
                Input.touches[0].deltaPosition.y,
                0);
        }
    }
}
