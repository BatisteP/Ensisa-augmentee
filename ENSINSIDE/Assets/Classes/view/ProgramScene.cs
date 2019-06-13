<<<<<<< HEAD:ENSINSIDE/Assets/Classes/view/ProgramScene.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
=======
﻿using System.Collections;
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
>>>>>>> af40df8fcb067052360aeafd4a9f33fd01a891cb:ENSINSIDE/Assets/Resources/BDD-classes/User.cs
