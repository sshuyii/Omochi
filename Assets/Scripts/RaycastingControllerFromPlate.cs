using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class RaycastingControllerFromPlate : MonoBehaviour
{


	public IntServerBackchannel intBackchannel;
	public GameObject EasyWifiManager;
	public Text TextCollision;
	public int DishType;
	//int currentNumberControllers = 3;
	//public string control;

	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player2;

	
	// Use this for initialization
	void Start ()
	{
		

	}
	

	void Update ()
	{	
		var array = EasyWifiManager.GetComponents<IntServerBackchannel>();

		//给每个EasyWifiManager上的同名脚本建一个序列，方便后续判断
		//var script1 = array[0];
		//var script2 = array[1];

		
		
		//int DishType = new int();
		//intBackchannel.setValue(Ham);

		
		//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

		//draw a line pointing forward of the plate
		Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*1, Color.green);

		RaycastHit hit;
		
		//if ray casted on potatoes
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f))
		{	
			
			
			if (hit.collider.CompareTag("Potato"))
			{
				
				DishType = 1;
				TextCollision.text = "Potatoes1 =" + DishType;
				
				
				//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			else if (hit.collider.CompareTag("Ham"))
			{
				
				DishType = 2;
				TextCollision.text = "Ham =" + DishType;
				//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

				
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			else
			{
				DishType = 0;
				TextCollision.text = "Potatoes1 =" + DishType;
				//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

			}
			
			//看EasyWifiManager里的ServerBackchannel到底贴的是哪个player的标签
			for(int i = 0; i < 3; i++)
			{
				if (array[i].player == player)
				{
					array[i].setValue(DishType); //决定向手机传输什么变量INT
				}
			}
			
			
			//用if函数判断碰撞的标签是否和传输数据脚本的标签相同
			/*if (script1.player == player)
			{
					
				script1.setValue(DishType);//决定向手机传输什么变量INT
			}
			else if (script2.player == player)
			{
					
				script2.setValue(DishType);//决定向手机传输什么变量INT
			}
			*/

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
