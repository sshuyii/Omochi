using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class RaycastingControllerFromPlate : MonoBehaviour {

	
	public int Potatoes1;
	public int Potatoes2;
	public IntServerBackchannel intBackchannel;
	public Text TextCollision;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		intBackchannel.setValue(Potatoes1);
		
		//draw a line pointing forward of the plate
		Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);

		RaycastHit hit;
		
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f))
		{

			if (hit.collider.CompareTag("Potato"))
			{
				
				Potatoes1 = 1;
				TextCollision.text = "Potatoes1 =" + Potatoes1;
				
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			else
			{
				Potatoes1 = 0;
				TextCollision.text = "Potatoes1 =" + Potatoes1;
			}
		}
		else
		{
			Potatoes1 = 0;
			TextCollision.text = "Potatoes1 =" + Potatoes1;
		}
		
	}
}
