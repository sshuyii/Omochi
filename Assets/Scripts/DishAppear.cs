using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.Core;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DishAppear : MonoBehaviour
{
	public Text dishAppearText;
	public GameObject PlayerPlate;
	[FormerlySerializedAs("potato")] public GameObject DishName;
	bool isPressed;
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
	public bool pickUp;
	public Text PickUpText;
	
	//此脚本中自定义的potatoOnPlate函数并没有每一帧都被调用，然而它应该每一帧都被调用
	//然而好像也没关系？
		
	// Use this for initialization
	void Start () {
		
		//Resources.Load<GameObject>("Prefabs/Dish");

	}

	void Update()
	{
		//PickUpText.text = pickUp.ToString();

	}

	public void potatoOnPlate(ButtonControllerType button)
	{
		
		isPressed = button.BUTTON_STATE_IS_PRESSED;
		PickUpText.text = pickUp.ToString();
		
		if (isPressed)
		{
			if (!pickUp)
			{
				dishAppearText.text = "pressed";
	
				Vector3 dishPos;
				dishPos.x = PlayerPlate.transform.position.x;
				dishPos.y = PlayerPlate.transform.position.y + 2.0f;
				dishPos.z = PlayerPlate.transform.position.z;

				Instantiate(DishName);
				pickUp = true;
				DishName.transform.position = dishPos;

			}

		}
		else
		{
			dishAppearText.text = "unpressed";
			pickUp = false;

		}


	}
	
	public void HamOnPlate(ButtonControllerType button)
	{
		
		isPressed = button.BUTTON_STATE_IS_PRESSED;
		PickUpText.text = pickUp.ToString();
		
		if (isPressed)
		{
			if (!pickUp)
			{
				dishAppearText.text = "pressed";

				Vector3 dishPos;
				dishPos.x = PlayerPlate.transform.position.x;
				dishPos.y = PlayerPlate.transform.position.y + 2.0f;
				dishPos.z = PlayerPlate.transform.position.z;

				Instantiate(DishName);
				pickUp = true;
				DishName.transform.position = dishPos;
			}



		}
		else
		{
			dishAppearText.text = "unpressed";
			pickUp = false;

		}


	}
	
}
