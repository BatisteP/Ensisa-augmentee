using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Room : MonoBehaviour
{
	private float id;
	private int floor;
	private string appelation;
	private string type;
	private string description;
	private int placesTot;
	private int pcTot;
	private int placesTaken;
	private int pcTaken;
	private int pcFailure;
	private ArrayList reservations;
	
	
	public Room(float i,int f,string a,string t, string d, int pt, int pc)
	{
		this.reservations=new ArrayList();
		this.id=i;
		this.floor=f;
		this.appelation=a;
		this.type=t;
		this.description=d;
		this.placesTot=pt;
		this.pcTot=pc;
		
		this.placesTaken=0;
		this.pcTaken=0;
		this.pcFailure=0;
	}
	
	public float getId()
	{
		return this.id;
	}
	
	public float getFloor()
	{
		return this.floor;
	}
	
	public string getName()
	{
		return this.name;
	}
	
	public bool isReserved(DateTime date)
	{
		foreach(Reservation res in reservations)
		{
			if (res.isActive(date))
			{
				return true;
			}
		}
		return false;
	}
	
	public void addReservation(Reservation res)
	{
		this.reservations.Add(res);
	}
	
	public void discardReservation(Reservation res)
	{
		this.reservations.Remove(res);
	}
	
	public void addFailure()
	{
		if (this.pcFailure < this.pcTot)
		{
			this.pcFailure++;
		}
		
	}
	
	public void solveFailure()
	{
		if (this.pcFailure >0)
		{
			this.pcFailure--;
		}
		
	}
	
	public void addStudent()
	{
		this.placesTaken++;
	}
	
	public void usePC()
	{
		this.pcTaken++;
	}
	
	public void leaveStudent()
	{
		this.placesTaken--;
	}
	
	public void freePC()
	{
		this.pcTaken--;
	}
	
	public int getPlacesTot()
	{
		return this.placesTot;
	}
	
	public int getPcTot()
	{
		return this.pcTot;
	}
	
	public int getPlacesFree()
	{
		return this.placesTot-this.placesTaken;
	}
	
	public int getPcFree()
	{
		return this.pcTot-this.pcTaken;
	}
	
	public ArrayList getReservations()
	{
		return this.reservations;
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
