using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.ServerControls;
using EasyWiFi.Core;

public class PlayerMove : MonoBehaviour
{
	private CharacterController characterController;

	private float moveL;
	private float moveR;
	
	public float speed = 50.0f;
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;


	public float radius = 0.3f;
	// Use this for initialization
	void Start ()
	{
		characterController = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update()
	{
		moveL = GetComponent<StandardTouchpadServerController>().touchMoveYLeft * speed;
		moveR = GetComponent<RightTouchpadServerController>().touchMoveYRight * speed;
		Vector3 move = transform.TransformDirection(new Vector3(0, 0, (moveL + moveR) / 2));
		characterController.Move(move * Time.deltaTime);
		characterController.transform.Rotate(0, (moveL - moveR) / radius * Time.deltaTime, 0);
	}
}
