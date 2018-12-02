using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.Core;
using UnityEngine.UI;

public class DishAppear : MonoBehaviour
{
	public Text dishAppearText;
	public GameObject PlayerPlate;
	public GameObject potato;
	bool isPressed;
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
	public bool pickUp;
		
	// Use this for initialization
	void Start () {
		
		//Resources.Load<GameObject>("Prefabs/Dish");

	}
	

	public void potatoOnPlate(ButtonControllerType button)
	{
		
		isPressed = button.BUTTON_STATE_IS_PRESSED;
		
		if (isPressed && !pickUp)
		{
	
			dishAppearText.text = "pressed";
			
			Vector3 dishPos;
			dishPos.x = PlayerPlate.transform.position.x;
			dishPos.y = PlayerPlate.transform.position.y + 2.0f;
			dishPos.z = PlayerPlate.transform.position.z;

			Instantiate(potato);
			pickUp = true;
			potato.transform.position = dishPos;



		}
		else if(!isPressed)
		{
			dishAppearText.text = "unpressed";
			pickUp = false;

		}

	}
}
