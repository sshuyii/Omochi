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
	public int OnPlate;
	
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
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.0f))
		{	
			
			
		
			if (hit.collider.CompareTag("Potato"))
			{
				
				DishType = 1;
				TextCollision.text = "Potatoes1 =" + DishType;
				
				
				//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
				
				
			}
			/*
			else if (hit.collider.CompareTag("Ham"))
			{
				
				DishType = 2;
				TextCollision.text = "Ham =" + DishType;
				//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

				
				//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
			}
			*/
			
			//如果碰到pea
			else if (hit.collider.CompareTag("Pea"))
			{
				
				DishType = 3;
				TextCollision.text = "Pea =" + DishType;
				
			}
			//如果碰到Banana
			else if (hit.collider.CompareTag("Banana"))
			{
				
				DishType = 4;
				TextCollision.text = "Banana =" + DishType;
				
			}
			//如果碰到Carrot
			else if (hit.collider.CompareTag("Carrot"))
			{
				
				DishType = 5;
				TextCollision.text = "Carrot =" + DishType;
				
			}
			//如果碰到Pumpkin
			else if (hit.collider.CompareTag("Pumpkin"))
			{
				
				DishType = 6;
				TextCollision.text = "Pumpkin =" + DishType;
				
			}
			//如果碰到Mushroom
			else if (hit.collider.CompareTag("Mushroom"))
			{
				
				DishType = 7;
				TextCollision.text = "Mushroom =" + DishType;
				
			}
			//如果碰到Onion
			else if (hit.collider.CompareTag("Onion"))
			{
				
				DishType = 8;
				TextCollision.text = "Onion =" + DishType;
				
			}
			//如果碰到Tomato
			else if (hit.collider.CompareTag("Tomato"))
			{
				
				DishType = 9;
				TextCollision.text = "Tomato =" + DishType;
				
			}
			//如果碰到Garlic
			else if (hit.collider.CompareTag("Garlic"))
			{
				
				DishType = 2;
				TextCollision.text = "Garlic =" + DishType;
				
			}
			
			//如果碰到shrimp
			else if (hit.collider.CompareTag("Shrimp"))
			{
				
				DishType = 11;
				TextCollision.text = "Shrimp =" + DishType;
				
			}
			//如果碰到Meatball
			else if (hit.collider.CompareTag("Meatball"))
			{
				
				DishType = 12;
				TextCollision.text = "Meatball =" + DishType;
				
			}
			//如果碰到Sausage
			else if (hit.collider.CompareTag("Sausage"))
			{
				
				DishType = 13;
				TextCollision.text = "Sausage =" + DishType;
				
			}
			//如果碰到Chicken
			else if (hit.collider.CompareTag("Chicken"))
			{
				
				DishType = 14;
				TextCollision.text = "Chicken =" + DishType;
				
			}
			//如果碰到Steak
			else if (hit.collider.CompareTag("Steak"))
			{
				
				DishType = 15;
				TextCollision.text = "Steak =" + DishType;
				
			}
			//如果碰到Bacon
			else if (hit.collider.CompareTag("Crayfish"))
			{
				
				DishType = 16;
				TextCollision.text = "Crayfish =" + DishType;
				
			}
			//如果碰到Bacon
			else if (hit.collider.CompareTag("Bacon"))
			{
				
				DishType = 17;
				TextCollision.text = "Bacon =" + DishType;
				
			}
			//如果碰到Crab
			else if (hit.collider.CompareTag("Crab"))
			{
				
				DishType = 18;
				TextCollision.text = "Crab =" + DishType;
				
			}
			//如果碰到Tempura
			else if (hit.collider.CompareTag("Tempura"))
			{
				
				DishType = 19;
				TextCollision.text = "Tempura =" + DishType;
				
			}
			
			else
			{
				DishType = 0;
				TextCollision.text = "Potatoes1 =" + DishType;
				//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT
			}
			
			
			//看EasyWifiManager里的ServerBackchannel到底贴的是哪个player的标签
			//用来代替了下面几行需要列举的代码
			for(int i = 0; i < 3; i++)
			{
				if (array[i].player == player)
				{
					array[i].setValue(DishType*10 + OnPlate); //决定向手机传输什么变量INT
				}
			}
			
			
			
			//用if函数判断碰撞的标签是否和传输数据脚本的标签相同
			//现在用for loop代替了，能少些几行代码
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
