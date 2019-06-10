using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Promo : MonoBehaviour
{
	private int year;
	private string spec;
	private ArrayList students;
	
	
	public Promo(int y, string s)
	{
		this.year=y;
		this.spec=s;
		this.students=new ArrayList();
	}
	
	public int getYear()
	{
		return this.year;
	}
	
	public string getSpec()
	{
		return this.spec;
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
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
