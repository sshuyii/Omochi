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
	//蹦出的字
	//vegetables
	public GameObject PeaText;
	public GameObject BananaText;
	public GameObject CarrotText;
	public GameObject PumpkinText;
	public GameObject PotatoText;
	public GameObject MushroomText;
	public GameObject OnionText;
	public GameObject TomatoText;
	public GameObject GarlicText;
	
	//meat
	public GameObject ShrimpText;
	public GameObject MeatballText;
	public GameObject SausageText;
	public GameObject ChickenText;
	public GameObject SteakText;
	public GameObject CrayfishText;
	public GameObject BaconText;
	public GameObject CrabText;
	public GameObject TempuraText;
	
	//获取盘子的位置
	//private GameObject xxx = GameObject.Find("ShrimpText");
	//public GameObject PotatoPlate;
	//public GameObject MushroomPlate;


	
	
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player2;

	
	// Use this for initialization
	void Start ()
	{
		
	}


	/*
	void PopUp(GameObject VegetableText)
	{
		Vector3 popUpPos;
		popUpPos.x = PotatoPlate.transform.position.x;
		popUpPos.y = PotatoPlate.transform.position.y + 0.3f;
		popUpPos.z = PotatoPlate.transform.position.z;

		VegetableText.transform.position = popUpPos;//决定字体出现的位置
		Instantiate(VegetableText);
		
	}
	*/
	
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
				
				PotatoText.SetActive(true);
				

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
				Instantiate(PeaText);

				
			}
			//如果碰到Banana
			else if (hit.collider.CompareTag("Banana"))
			{
				
				DishType = 4;
				TextCollision.text = "Banana =" + DishType;
				Instantiate(BananaText);

			}
			//如果碰到Carrot
			else if (hit.collider.CompareTag("Carrot"))
			{
				
				DishType = 5;
				TextCollision.text = "Carrot =" + DishType;
				Instantiate(CarrotText);

			}
			//如果碰到Pumpkin
			else if (hit.collider.CompareTag("Pumpkin"))
			{
				
				DishType = 6;
				TextCollision.text = "Pumpkin =" + DishType;
				Instantiate(PumpkinText);

			}
			//如果碰到Mushroom
			else if (hit.collider.CompareTag("Mushroom"))
			{
				
				DishType = 7;
				TextCollision.text = "Mushroom =" + DishType;
				Instantiate(MushroomText);

			}
			//如果碰到Onion
			else if (hit.collider.CompareTag("Onion"))
			{
				
				DishType = 8;
				TextCollision.text = "Onion =" + DishType;
				Instantiate(OnionText);

			}
			//如果碰到Tomato
			else if (hit.collider.CompareTag("Tomato"))
			{
				
				DishType = 9;
				TextCollision.text = "Tomato =" + DishType;
				Instantiate(TomatoText);

			}
			//如果碰到Garlic
			else if (hit.collider.CompareTag("Garlic"))
			{
				
				DishType = 2;
				TextCollision.text = "Garlic =" + DishType;
				Instantiate(GarlicText);

			}
			
			//如果碰到shrimp
			else if (hit.collider.CompareTag("Shrimp"))
			{
				
				DishType = 11;
				TextCollision.text = "Shrimp =" + DishType;
				Instantiate(ShrimpText);

			}
			//如果碰到Meatball
			else if (hit.collider.CompareTag("Meatball"))
			{
				
				DishType = 12;
				TextCollision.text = "Meatball =" + DishType;
				Instantiate(MeatballText);

			}
			//如果碰到Sausage
			else if (hit.collider.CompareTag("Sausage"))
			{
				
				DishType = 13;
				TextCollision.text = "Sausage =" + DishType;
				Instantiate(SausageText);

			}
			//如果碰到Chicken
			else if (hit.collider.CompareTag("Chicken"))
			{
				
				DishType = 14;
				TextCollision.text = "Chicken =" + DishType;
				Instantiate(ChickenText);

			}
			//如果碰到Steak
			else if (hit.collider.CompareTag("Steak"))
			{
				
				DishType = 15;
				TextCollision.text = "Steak =" + DishType;
				Instantiate(SteakText);

			}
			//如果碰到Bacon
			else if (hit.collider.CompareTag("Crayfish"))
			{
				
				DishType = 16;
				TextCollision.text = "Crayfish =" + DishType;
				Instantiate(CrayfishText);

			}
			//如果碰到Bacon
			else if (hit.collider.CompareTag("Bacon"))
			{
				
				DishType = 17;
				TextCollision.text = "Bacon =" + DishType;
				Instantiate(BaconText);

			}
			//如果碰到Crab
			else if (hit.collider.CompareTag("Crab"))
			{
				
				DishType = 18;
				TextCollision.text = "Crab =" + DishType;
				Instantiate(CrabText);

			}
			//如果碰到Tempura
			else if (hit.collider.CompareTag("Tempura"))
			{
				
				DishType = 19;
				TextCollision.text = "Tempura =" + DishType;
				Instantiate(TempuraText);

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
