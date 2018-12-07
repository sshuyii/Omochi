using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class OnPlate : MonoBehaviour
{

	public int onPlate;
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
	public GameObject EasyWifiManager;
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
	}

	private void OnTriggerExit(Collider other)
	{
		var array = EasyWifiManager.GetComponents<IntServerBackchannelDishes>();

		//如果没有土豆在碰撞的话，手机上所有土豆都要消失
		if (other.CompareTag("Potato"))
		{
			onPlate = 1;
		}
		
		else if(other.CompareTag("Ham"))
		{

			onPlate = 2;
		}
		
	


		//loop着往手机传输变量
		for(int i = 0; i < 3; i++)
		{
			if (array[i].player == player)
			{
				array[i].setValue(onPlate); //决定向手机传输什么变量INT
			}
		}
	}
}
