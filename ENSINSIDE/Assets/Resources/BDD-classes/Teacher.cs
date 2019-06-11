using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : User
{
	private string firstname;
	private string forename;
	private string password;
	private string mail;
	private float room;
	private bool inRoom;
	private bool ismodified;
	
	public Teacher(string n, string f, string p, string m, float r)
	{
		this.firstname=n;
		this.forename=f;
		this.password=p;
		this.mail=m;
		this.room=r;
		this.inRoom=false;
		this.ismodified=false;
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
	
	public override void setMail(string m)
	{
		this.mail=m;
		this.ismodified=true;
	}
	
	public void changeRoom(float r)
	{
		this.room=r;
		this.ismodified=true;
	}
	
	public bool canRes()
	{
		return true;
	}
	
	public void enterRoom()
	{
		this.inRoom=true;
		this.ismodified=true;
	}
	
	public void leaveRoom()
	{
		this.inRoom=false;
		this.ismodified=true;
	}
	
	public bool isInRoom()
	{
		return this.inRoom;
	}
	
	public bool isModified()
	{
		return this.ismodified;
	}
	
	public override void setPassword(string p)
	{
		this.password=p;
		this.ismodified=true;
	}
	
	public override string getPassword()
	{
		return this.password;
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
