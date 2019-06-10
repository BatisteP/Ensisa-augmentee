using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projet2A : MonoBehaviour
{
	private string itsname;
	private string description;
	private ArrayList authors;
	
	public Projet2A(string n, string d)
	{
		this.itsname=n;
		this.description=d;
		this.authors=new ArrayList();
	}
	
	public void addAuthor(User u)
	{
		this.authors.Add(u);
	}
	
	public void removeAuthor(User u)
	{
		this.authors.Remove(u);
	}
	
	public string getName()
	{
		return this.itsname;
	}
	
	public string getDescript()
	{
		return this.description;
	}
	
	public ArrayList getAuthors()
	{
		return this.authors;
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
