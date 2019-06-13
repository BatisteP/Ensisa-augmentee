using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Class : Reservation
{
	private User user;
	private float room;
	private Promo promo;
	private DateTime begin;
	private DateTime end;
	private string description;
	private bool ismodified;
	
	public Class(User u, float r, Promo p, DateTime b, DateTime e, string des)
	{
		this.user=u;
		this.room=r;
		this.promo=p;
		this.begin=b;
		this.end=e;
		this.description=des;
		this.ismodified=false;
	}
	
	public override bool isActive(DateTime date)
	{
		if (this.begin.Date==date.Date)
		{
			if (this.begin.Hour<date.Hour && this.end.Hour>date.Hour)
			{
				return true;
			}
			else if (this.begin.Hour==date.Hour && this.begin.Minute <= date.Minute)
			{
				return true;
			}
			else if (this.end.Hour==date.Hour && this.end.Hour > date.Minute)
			{
				return true;
			}
		}
		return false;
	}
	
	public override User getUser()
	{
		return this.user;
	}
	
	public override string getDescript()
	{
		return this.description;
	}
	
	public override float getRoom()
	{
		return this.room;
	}
	
	public override void setUser(User u)
	{
		this.user=u;
		this.ismodified=true;
	}
	
	public Promo getPromo()
	{
		return this.promo;
	}
	
	public override bool isModified()
	{
		return this.ismodified;
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
