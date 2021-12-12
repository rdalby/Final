using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Just wanted a class for the ItemIndicator to be able to do things with later
// additional items to be added in would be blinking when close to boss

public class ItemIndicator : MonoBehaviour 
{

	public GameObject indicator;

	void awake ()
	{
		indicator.SetActive(false);
	}

}

