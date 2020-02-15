using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyWiFi.ServerControls;
using EasyWiFi.Core;

public class PlayerMove : MonoBehaviour
{
	private CharacterController characterController;
	public List<GameObject> foodOnPlate = new List<GameObject>();
	private float moveL;
	private float moveR;
	
	public float speed = 50.0f;
	public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
	private float v;//速度
	private float w;//角速度
	public float forceRatio = 3;
	public float radiusForce = 1;
	public float radius = 0.3f;
	// Use this for initialization
	void Start ()
	{
		characterController = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update()
	{
		//used for mobile input
//		moveL = GetComponent<StandardTouchpadServerController>().touchMoveYLeft * speed;
//		moveR = GetComponent<RightTouchpadServerController>().touchMoveYRight * speed;
//		Vector3 move = transform.TransformDirection(new Vector3(0, 0, (moveL + moveR) / 2));
//		v = (moveL + moveR) / 2;
//		
//		characterController.Move(move * Time.deltaTime);
//		characterController.transform.Rotate(0, (moveL - moveR) / radius * Time.deltaTime, 0);
//		w = (moveL - moveR) / radius;
//		Vector3 movement = Vector3.zero;
//		float vertSpeed = 0;
//		if (!characterController.isGrounded)
//		{
//			vertSpeed -= 9.8f *  5 * Time.deltaTime;
//		}
//		movement.y = vertSpeed;
//		characterController.Move(movement * Time.deltaTime);

		//used for controller input
		moveL = Input.GetAxis("LeftY") * speed;
		moveR = Input.GetAxis("RightY") * speed;
		Vector3 move = transform.TransformDirection(new Vector3(0, 0, (moveL + moveR) / 2));
		v = (moveL + moveR) / 2;
		
		characterController.Move(move * Time.deltaTime);
		characterController.transform.Rotate(0, (moveL - moveR) / radius * Time.deltaTime, 0);
		w = (moveL - moveR) / radius;
		Vector3 movement = Vector3.zero;
		float vertSpeed = 0;
		if (!characterController.isGrounded)
		{
			vertSpeed -= 9.8f *  5 * Time.deltaTime;
		}
		movement.y = vertSpeed;
		characterController.Move(movement * Time.deltaTime);

		
		print("LeftY = " +  Input.GetAxis("LeftY"));
		print("RightY = " +  Input.GetAxis("RightY"));

	}

	public void AddFoodList(GameObject newFood)
	{
		foodOnPlate.Add(newFood);
		
	}

	public void RemoveFoodList(GameObject removeFood)
	{
		foodOnPlate.Remove(removeFood);
	}

	public void MoveFoodOnPlate()
	{
		Vector3 SpeedVertical = transform.forward * v;
		Vector3 SpeedHorizontal = transform.right * w* radiusForce;
		Vector3 force = (SpeedVertical + SpeedHorizontal) * forceRatio;
		foreach (GameObject food in foodOnPlate)
		{	
			food.GetComponent<Rigidbody>().AddForceAtPosition(force * forceRatio,food.transform.position);
		}
	}
	
}
