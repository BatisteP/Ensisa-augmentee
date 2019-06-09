using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{
	private string itsname;
	private ArrayList students;
	
	
	public Club(string n)
	{
		this.itsname=n;
		this.students=new ArrayList();
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
	}
	
	public void removeStudent(Student s)
	{
		this.students.Remove(s);
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
