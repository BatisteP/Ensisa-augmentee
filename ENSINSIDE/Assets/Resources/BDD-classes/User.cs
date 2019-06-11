using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class User : MonoBehaviour
{
	
	
	public abstract string getName();
	public abstract string getForename();
	public abstract string getMail();
	public abstract void setPassword(string p);
	public abstract void setMail(string m);
	public abstract string getPassword();
	public abstract bool isModified();
	public abstract bool canRes();
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
