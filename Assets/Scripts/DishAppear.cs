using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.Core;

public class DishAppear : MonoBehaviour
{
	public GameObject PlayerPlate;
		
	// Use this for initialization
	void Start () {
		
	}
	

	public void potatoOnPlate(BoolBackchannelType boolBackchannel)
	{

		if (boolBackchannel.BOOL_VALUE)
		{
			GameObject Potato = Resources.Load<GameObject>("Prefabs/Potato");
			
			Vector3 dishPos;
			dishPos.x = PlayerPlate.transform.position.x;
			dishPos.y = PlayerPlate.transform.position.y;
			dishPos.z = PlayerPlate.transform.position.z + 2;

			Potato.transform.position = dishPos;
			
				
			boolBackchannel.BOOL_VALUE = false;
		}
	}
}
