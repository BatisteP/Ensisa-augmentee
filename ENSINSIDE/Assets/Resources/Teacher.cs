using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : User
{
	private string firstname;
	private string forename;
	private string mail;
	private float room;
	
	public Teacher(string n, string f, string m, float r)
	{
		this.firstname=n;
		this.forename=f;
		this.mail=m;
		this.room=r;
	}
	
	public override string getName()
	{
		return this.firstname;
	}
	
	public override string getForename()
	{
		return this.forename;
	}
	
	public float getRoom()
	{
		return this.room;
	}
	
	public override string getMail()
	{
		return this.mail;
	}
	
	public void changeRoom(float r)
	{
		this.room=r;
	}
	
	public bool canRes()
	{
		return true;
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
