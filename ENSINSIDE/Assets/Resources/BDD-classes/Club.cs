using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{
	private string itsname;
	private ArrayList students;
	private bool ismodified;
	
	public Club(string n)
	{
		this.itsname=n;
		this.students=new ArrayList();
		this.ismodified=false;
	}
	
	public bool containStudent(Student student)
	{
		foreach(Student s in this.students)
		{
			if (student==s)
			{
				return true;
			}
		}
		return false;
	}
	
	public void addStudent(Student s)
	{
		this.students.Add(s);
		this.ismodified=true;
	}
	
	public void removeStudent(Student s)
	{
		this.students.Remove(s);
		this.ismodified=true;
	}
	
	public bool isModified()
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
