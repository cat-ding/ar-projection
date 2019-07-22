using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelManager : MonoBehaviour
{
	public GameObject theObject;
	bool state;

	void Start()
	{
		state = true;
	}

	public void showObject()
	{
		state = !state;
		theObject.SetActive(state);
	}
}