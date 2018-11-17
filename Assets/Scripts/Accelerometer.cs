﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
	public bool isFlat = true;
	private Rigidbody rigid;
	
	// Use this for initialization
	void Start ()
	{
		rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update()
	{

		Vector3 tilt = Input.acceleration;

		if (isFlat)
		{
			tilt = Quaternion.Euler(90, 270, 0) * tilt;


			rigid.AddForce(tilt);
			Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);

			//rigid.AddForce(Input.acceleration);
		}
	}
}