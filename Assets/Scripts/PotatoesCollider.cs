using UnityEngine;
using System;
using System.Collections;
using EasyWiFi.Core;
using EasyWiFi.ServerBackchannels;
using UnityEngine.UI;

public class PotatoesCollider : MonoBehaviour
{

	public GameObject DishText;

	public int countCollider;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (countCollider == 0)
		{
			DishText.SetActive(false);

		}
	}
	
	//if collides with the potato's collider
	void OnTriggerEnter(Collider other)
	{
		print(other.name);
		if(other.CompareTag("Player1Text") || other.CompareTag("Player2"))
		{
			DishText.SetActive(true);
			countCollider += 1;
		}


	}
	
	void OnTriggerExit(Collider other)
	{
		
		if(other.CompareTag("Player1Text") || other.CompareTag("Player2"))
		{
			countCollider -= 1;
		}


	}
	
	
	
}
