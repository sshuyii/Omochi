using System.Collections;
using System.Collections.Generic;
using EasyWiFi.ClientControls;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class dishApearOnPhone : MonoBehaviour
{
	public GameObject self;
	public PotatoSwitchControl PotatoSwitchControl;
	
	//vegetable
	public GameObject Potato;
	public GameObject Pea;
	public GameObject Banana;
	public GameObject Carrot;
	public GameObject Pumpkin;
	public GameObject Mushroom;
	public GameObject Onion;
	public GameObject Tomato;
	public GameObject Garlic;
	
	//meat
	public GameObject Shrimp;
	public GameObject Meatball;
	public GameObject Sausage;
	public GameObject Chicken;
	public GameObject Steak;
	public GameObject Crayfish;
	public GameObject Bacon;
	public GameObject Crab;
	public GameObject Tempura;
	
	private GameObject dishName;
	
	public Text PotatoText;
	public bool AlreadyAppeared;
	public GameObject clientControlPanel;

	public Text ScreenValue;
		
	// Use this for initialization
	void Start ()
	{
		//Potato = Resources.Load<GameObject>("Prefabs/PotatoPhone");
	}
	
	// Update is called once per frame
	void Update ()
	{
		int dishNumber = PotatoSwitchControl.DishTypePhone / 10;
		ScreenValue.text = dishNumber.ToString();

		int yushu = PotatoSwitchControl.DishTypePhone % 10;
		
		//PotatoText.text = self.GetComponent<ButtonClientController>().pressed.ToString();
		
		/*
		//12/10目前决定不要UI出现在手机上了
		//按了一下之后，菜就出现在手机上的盘子里
		if (self.GetComponent<ButtonClientController>().pressed && !AlreadyAppeared)
		{
			PotatoText.text = "Pressed";
			dishName = Potato;
			
			//决定到底要在手机上显示哪个菜的图片
			
			//vegetables
			if (dishNumber == 1)
			{
				dishName = Potato;
			}
			else if (dishNumber == 2)
			{
				dishName = Garlic;
			}
			else if (dishNumber == 3)
			{
				dishName = Pea;
			}
			else if (dishNumber == 4)
			{
				dishName = Banana;
			}
			else if (dishNumber == 5)
			{
				dishName = Carrot;
			}
			else if (dishNumber == 6)
			{
				dishName = Pumpkin;
			}
			else if (dishNumber == 7)
			{
				dishName = Mushroom;
			}
			else if (dishNumber == 8)
			{
				dishName = Onion;
			}
			else if (dishNumber == 9)
			{
				dishName = Tomato;
			}
			
			//meat
			else if (dishNumber == 11)
			{
				dishName = Shrimp;
			}
			else if (dishNumber == 12)
			{
				dishName = Meatball;
			}
			else if (dishNumber == 13)
			{
				dishName = Sausage;
			}
			else if (dishNumber == 14)
			{
				dishName = Chicken;
			}
			else if (dishNumber == 15)
			{
				dishName = Steak;
			}
			else if (dishNumber == 16)
			{
				dishName = Crayfish;
			}
			else if (dishNumber == 17)
			{
				dishName = Bacon;
			}
			else if (dishNumber == 18)
			{
				dishName = Crab;
			}
			else if (dishNumber == 19)
			{
				dishName = Tempura;
			}

			var PotatoPhone = Instantiate(dishName);
			PotatoPhone.transform.SetParent(clientControlPanel.transform);
			

			Vector3 onPlate = new Vector3();
			onPlate.x = 500;
			onPlate.y = 150;
			onPlate.z = 0;

			PotatoPhone.transform.position = onPlate;

			AlreadyAppeared = true;
		}
		else if(!self.GetComponent<ButtonClientController>().pressed)
		{
			PotatoText.text = "unPressed";
			AlreadyAppeared = false;
		}
		*/
		
	}
	
	
}
