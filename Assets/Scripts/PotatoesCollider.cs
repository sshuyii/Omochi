using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class PotatoesCollider : MonoBehaviour
{

	public int Potatoes1;
	public int Potatoes2;
	public IntServerBackchannel intBackchannel;

	public Text TextCollision;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		intBackchannel.setValue(Potatoes1);
	}
	
	//if collides with the potato's collider
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player1"))
		{
			Potatoes1 = 1;
			//boolBackchannel.setValue(Potatoes1);

			TextCollision.text = "Potatoes1 =" + Potatoes1;
			
		}
		else if (other.gameObject.CompareTag("Player2"))
		{
			Potatoes2 = 1;
		}
		
		
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player1"))
		{
			Potatoes1 = 0;
			//print(Potatoes1);
			TextCollision.text = "Potatoes1 =" + Potatoes1;
		}
	}
	
	
	
}
