using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.Core;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DishAppear : MonoBehaviour
{
	public Text dishAppearText;
	public PlayerMove playerMove;
	public GameObject PlayerPlate;
	[FormerlySerializedAs("potato")] public GameObject DishName;
	bool isPressed;
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
	public bool pickUp;
	public Text PickUpText;
	
	public GameObject Potato;
	public GameObject Pea;
	public GameObject Banana;
	public GameObject Carrot;
	public GameObject Pumpkin;
	public GameObject Mushroom;
	public GameObject Onion;
	public GameObject Tomato;
	public GameObject Garlic;
	private bool LastFrameIsPressed = false;
	public RaycastingControllerFromPlate RaycastScript;
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
	//如果按钮被按下，那么盘子上方出现一个potato
	public void potatoOnPlate(ButtonControllerType button)
	{
		isPressed = button.BUTTON_STATE_IS_PRESSED;
		dishAppearText.text = "unpressed";
		if (LastFrameIsPressed != isPressed)
		{	
			PickUpText.text = pickUp.ToString();

			
			//决定掉下来的应该是什么蔬菜
			if (RaycastScript.DishType == 1)
			{
				DishName = Potato;
			}
			else if (RaycastScript.DishType == 2)
			{
				DishName = Garlic;
			}
			else if (RaycastScript.DishType == 3)
			{
				DishName = Pea;
			}
			else if (RaycastScript.DishType == 4)
			{
				DishName = Banana;
			}
			else if (RaycastScript.DishType == 5)
			{
				DishName = Carrot;
			}
			else if (RaycastScript.DishType == 6)
			{
				DishName = Pumpkin;
			}
			else if (RaycastScript.DishType == 7)
			{
				DishName = Mushroom;
			}
			else if (RaycastScript.DishType == 8)
			{
				DishName = Onion;
			}
			else if (RaycastScript.DishType == 9)
			{
				DishName = Tomato;
			}

			dishAppearText.text = button.BUTTON_STATE_IS_PRESSED.ToString();
			
			Vector3 dishPos;
			dishPos.x = PlayerPlate.transform.position.x;
			dishPos.y = PlayerPlate.transform.position.y + 0.2f;
			dishPos.z = PlayerPlate.transform.position.z;

			
			playerMove.AddFoodList(Instantiate(DishName));
			pickUp = true;
			DishName.transform.position = dishPos;

			/*if (isPressed)
			{
				if (!pickUp)
				{
					dishAppearText.text = "pressed";
		
					Vector3 dishPos;
					dishPos.x = PlayerPlate.transform.position.x;
					dishPos.y = PlayerPlate.transform.position.y + 0.2f;
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
	
			}*/
		}
		LastFrameIsPressed = button.BUTTON_STATE_IS_PRESSED;
	}
	
	
	
	
}
