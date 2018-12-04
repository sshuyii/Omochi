using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using EasyWiFi.Core;

public class PotatoSwitchControl : MonoBehaviour
{
	public Text ValueText;
	public GameObject PotatoSwitch;
	public GameObject HamSwitch;
	// Use this for initialization
	void Start () {
		
	}
	


	public void ButtonActivate(IntBackchannelType intBackchannel)
	{
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
		
	}

	
}
