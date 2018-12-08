using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using EasyWiFi.Core;

public class PotatoSwitchControl : MonoBehaviour
{
	public Text ValueText;
	public GameObject PotatoSwitch;

	public int DishTypePhone;
	
	//public GameObject HamSwitch;
	// Use this for initialization
	void Start () {
		
	}
	

	//如果player靠近盘子，dishtype从电脑端传送到了手机端，按钮就要出现在手机上
	public void ButtonActivate(IntBackchannelType intBackchannel)
	{
		/*
		//之前的每个按钮都有单独的gameobject
		//if potatoes
		if(intBackchannel.INT_VALUE == 1)
		{
			PotatoSwitch.SetActive(true);
			ValueText.text = intBackchannel.INT_VALUE.ToString();
		}
		//if ham
		else if(intBackchannel.INT_VALUE == 2)
		{
			HamSwitch.SetActive(true);
			ValueText.text = intBackchannel.INT_VALUE.ToString();
		}
		//if none of vegetables nor meat
		else if(intBackchannel.INT_VALUE == 0)
		{
			PotatoSwitch.SetActive(false);
			HamSwitch.SetActive(false);
			ValueText.text = intBackchannel.INT_VALUE.ToString();

		}
		*/
		//新版的，所有手机上的按钮都用同一个
		//if potatoes
		
		//if none of vegetables nor meat
		if(intBackchannel.INT_VALUE == 0)
		{
			PotatoSwitch.SetActive(false);
			ValueText.text = intBackchannel.INT_VALUE.ToString();

		}
		else
		{
			PotatoSwitch.SetActive(true);
			ValueText.text = intBackchannel.INT_VALUE.ToString();
		}
		//把传输过来的值记录在一个public函数里
		DishTypePhone = intBackchannel.INT_VALUE;
	}
	
	//判断菜还在不在盘子上，不在盘子上的话就要从手机上消失
	public void Dish2D(IntBackchannelType intBackchannel)
	{
		//potatoes
		if(intBackchannel.INT_VALUE == 1)
		{
			var Potato2D = GameObject.FindWithTag("Potato2D");
			Destroy(Potato2D);
		}
		
		
		
	}

	
}
