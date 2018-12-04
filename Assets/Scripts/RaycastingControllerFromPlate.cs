using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class RaycastingControllerFromPlate : MonoBehaviour
{


	public IntServerBackchannel intBackchannel;
	public Text TextCollision;
	public int DishType;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{	
		//int DishType = new int();
		//intBackchannel.setValue(Ham);

		
		//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

		//draw a line pointing forward of the plate
		Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);

		RaycastHit hit;
		
		//if ray casted on potatoes
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 8.0f))
		{
			
			if (hit.collider.CompareTag("Potato"))
			{
				
				DishType = 1;
				TextCollision.text = "Potatoes1 =" + DishType;
				intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			else if (hit.collider.CompareTag("Ham"))
			{
				
				DishType = 2;
				TextCollision.text = "Ham =" + DishType;
				intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

				
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			else
			{
				DishType = 0;
				TextCollision.text = "Potatoes1 =" + DishType;
				intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

			}
		}
		else
		{
			DishType = 0;
			TextCollision.text = "Potatoes1 =" + DishType;
			//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

		}
			//TextCollision.text = "Potatoes1 = null";

		





	}

/*
	void pickUpDishes(String tagName, int dishType)
	{
		
		RaycastHit hit;
		
		//if ray casted on potatoes
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f))
		{

			if (hit.collider.CompareTag(tagName))
			{
				
				dishType = 1;
				TextCollision.text = "Potatoes1 =" + dishType;
				
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			else
			{
				dishType = 0;
				TextCollision.text = "Potatoes1 =" + dishType;
			}
		}
		else
		{
			dishType = 0;
			TextCollision.text = "Potatoes1 = null";
		}

	}
	*/
}
