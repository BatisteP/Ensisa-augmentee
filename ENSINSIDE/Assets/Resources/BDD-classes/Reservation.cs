using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Reservation : MonoBehaviour
{

	
	public abstract bool isActive(DateTime date);
	
	public abstract User getUser();
	
	public abstract string getDescript();
	
	public abstract void setUser(User u);
	
	public abstract float getRoom();
	
	public abstract bool isModified();
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
