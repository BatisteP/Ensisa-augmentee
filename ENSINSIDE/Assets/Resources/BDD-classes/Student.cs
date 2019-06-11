using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : User
{
	private string firstname;
	private string forename;
	private string mail;
	private ArrayList clubs;
	private string password;
	private Promo promo;
	private bool ismodified;
	
	public Student(string n, string f, string pa, string m, Promo p)
	{
		this.firstname=n;
		this.forename=f;
		this.password=pa;
		this.mail=m;
		this.clubs= new ArrayList();
		this.promo=p;
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
	
	public Promo getPromo()
	{
		return this.promo;
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
	
	public void addClub(Club c)
	{
		this.clubs.Add(c);
		this.ismodified=true;
	}
	
	public bool canRes()
	{
		return true;
	}
	
	public override bool isModified()
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
