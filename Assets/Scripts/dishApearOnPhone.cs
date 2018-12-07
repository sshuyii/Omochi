using System.Collections;
using System.Collections.Generic;
using EasyWiFi.ClientControls;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class dishApearOnPhone : MonoBehaviour
{
	public GameObject self;
	[FormerlySerializedAs("Potato")] public GameObject Dish;
	public Text PotatoText;
	public bool AlreadyAppeared;
	public GameObject clientControlPanel;
		
	// Use this for initialization
	void Start ()
	{
		//Potato = Resources.Load<GameObject>("Prefabs/PotatoPhone");
	}
	
	// Update is called once per frame
	void Update ()
	{

		//PotatoText.text = self.GetComponent<ButtonClientController>().pressed.ToString();
		
		if (self.GetComponent<ButtonClientController>().pressed && !AlreadyAppeared)
		{
			PotatoText.text = "Pressed";
			var PotatoPhone = Instantiate(Dish);
			PotatoPhone.transform.SetParent(clientControlPanel.transform);
			

			Vector3 onPlate = new Vector3();
			onPlate.x = 300;
			onPlate.y = 150;
			onPlate.z = 0;

			PotatoPhone.transform.position = onPlate;		
			

			AlreadyAppeared = true;
		}
		else if(!self.GetComponent<ButtonClientController>().pressed)
		{
			PotatoText.text = "unPressed";
			AlreadyAppeared = false;
		}
		
	}
	
	
}
