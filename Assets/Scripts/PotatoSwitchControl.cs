using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using EasyWiFi.Core;

public class PotatoSwitchControl : MonoBehaviour
{
	public Text ValueText;
	public GameObject PickUpSwitch;
	// Use this for initialization
	void Start () {
		
	}
	


	public void ButtonActivate(IntBackchannelType intBackchannel)
	{
		//if potatoes
		if(intBackchannel.INT_VALUE == 1)
		{
			PickUpSwitch.SetActive(true);
			ValueText.text = intBackchannel.INT_VALUE.ToString();
		}
		else
		{
			PickUpSwitch.SetActive(false);
			ValueText.text = intBackchannel.INT_VALUE.ToString();

		}
		
		//if lamb
	}

	
}
