using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class CubeInsteadOfRaycast : MonoBehaviour
{



	public int DishType;

	//蹦出的字
	//vegetables
//	public GameObject PeaText;
//	public GameObject BananaText;
//	public GameObject CarrotText;
//	public GameObject PumpkinText;
	public GameObject PotatoText;
//	public GameObject MushroomText;
//	public GameObject OnionText;
//	public GameObject TomatoText;
//	public GameObject GarlicText;
//	
//	//meat
//	public GameObject ShrimpText;
//	public GameObject MeatballText;
//	public GameObject SausageText;
//	public GameObject ChickenText;
//	public GameObject SteakText;
//	public GameObject CrayfishText;
//	public GameObject BaconText;
//	public GameObject CrabText;
//	public GameObject TempuraText;
//	
	//获取盘子的位置
	//private GameObject xxx = GameObject.Find("ShrimpText");
	//public GameObject PotatoPlate;
	//public GameObject MushroomPlate;




	


	// Use this for initialization
	void Start()
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

	void Update()
	{


	}

	private void OnTriggerExit(Collider other)
	{
		DishType = 0;
		//TextColiision.text = "Potatoes1 =" + DishType;
	}



	private void OnTriggerStay(Collider other)
	{


		if (other.CompareTag("Potato"))
		{

			DishType = 1;
			//TextColiision.text = "Potatoes1 =" + DishType;

			PotatoText.SetActive(true);



			//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT
			//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);


		}
		/*
		else if (other.CompareTag("Ham"))
		{
			
			DishType = 2;
			//TextColiision.text = "Ham =" + DishType;
			//intBackchannel.setValue(DishType);//决定向手机传输什么变量INT

			
			//Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*100, Color.green);
		}
		*/

		//如果碰到pea
		else if (other.CompareTag("Pea"))
		{

			DishType = 3;
			//TextColiision.text = "Pea =" + DishType;
			//PeaText.SetActive(true);


		}
		//如果碰到Banana
		else if (other.CompareTag("Banana"))
		{

			DishType = 4;
			//TextColiision.text = "Banana =" + DishType;
			//BananaText.SetActive(true);


		}
		//如果碰到Carrot
		else if (other.CompareTag("Carrot"))
		{

			DishType = 5;
			//TextColiision.text = "Carrot =" + DishType;
			//CarrotText.SetActive(true);


		}
		//如果碰到Pumpkin
		else if (other.CompareTag("Pumpkin"))
		{

			DishType = 6;
			//TextColiision.text = "Pumpkin =" + DishType;
			//PumpkinText.SetActive(true);


		}
		//如果碰到Mushroom
		else if (other.CompareTag("Mushroom"))
		{

			DishType = 7;
			//TextColiision.text = "Mushroom =" + DishType;
			//MushroomText.SetActive(true);


		}
		//如果碰到Onion
		else if (other.CompareTag("Onion"))
		{

			DishType = 8;
			//TextColiision.text = "Onion =" + DishType;
			//OnionText.SetActive(true);


		}
		//如果碰到Tomato
		else if (other.CompareTag("Tomato"))
		{

			DishType = 9;
			//TextColiision.text = "Tomato =" + DishType;
			//TomatoText.SetActive(true);


		}
		//如果碰到Garlic
		else if (other.CompareTag("Garlic"))
		{

			DishType = 2;
			//TextColiision.text = "Garlic =" + DishType;
			//GarlicText.SetActive(true);


		}

		//如果碰到shrimp
		else if (other.CompareTag("Shrimp"))
		{

			DishType = 11;
			//TextColiision.text = "Shrimp =" + DishType;
			//ShrimpText.SetActive(true);


		}
		//如果碰到Meatball
		else if (other.CompareTag("Meatball"))
		{

			DishType = 12;
			//TextColiision.text = "Meatball =" + DishType;
			//MeatballText.SetActive(true);


		}
		//如果碰到Sausage
		else if (other.CompareTag("Sausage"))
		{

			DishType = 13;
			//TextColiision.text = "Sausage =" + DishType;
			//SausageText.SetActive(true);


		}
		//如果碰到Chicken
		else if (other.CompareTag("Chicken"))
		{

			DishType = 14;
			//TextColiision.text = "Chicken =" + DishType;
			//ChickenText.SetActive(true);


		}
		//如果碰到Steak
		else if (other.CompareTag("Steak"))
		{

			DishType = 15;
			//TextColiision.text = "Steak =" + DishType;
			//SteakText.SetActive(true);


		}
		//如果碰到Bacon
		else if (other.CompareTag("Crayfish"))
		{

			DishType = 16;
			//TextColiision.text = "Crayfish =" + DishType;
			//CrayfishText.SetActive(true);


		}
		//如果碰到Bacon
		else if (other.CompareTag("Bacon"))
		{

			DishType = 17;
			//TextColiision.text = "Bacon =" + DishType;
			//BaconText.SetActive(true);


		}
		//如果碰到Crab
		else if (other.CompareTag("Crab"))
		{

			DishType = 18;
			//TextColiision.text = "Crab =" + DishType;
			//CrabText.SetActive(true);


		}
		//如果碰到Tempura
		else if (other.CompareTag("Tempura"))
		{

			DishType = 19;
			//TextColiision.text = "Tempura =" + DishType;
			//TempuraText.SetActive(true);


		}
		else
		{
			DishType = 0;
			//TextColiision.text = "Potatoes1 =" + DishType;

		}
	}
}
