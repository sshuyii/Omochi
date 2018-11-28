 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatePosition : MonoBehaviour
{


	public GameObject Left;
	public GameObject Right;
	public GameObject PlateRef;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//求两个轮子连线的中点坐标
		Vector3 platePos = new Vector3();
		
		platePos.x = (Left.transform.position.x + Right.transform.position.x) / 2;
		platePos.z = (Left.transform.position.z + Right.transform.position.z) / 2;
		platePos.y = 14;
		
		
		//盘子朝向和连线垂直
		//得到与连线向量垂直的向量
		Vector2 plateRef = new Vector2();
		
		plateRef.x = Left.transform.position.z - Right.transform.position.z;
		plateRef.y = Right.transform.position.x - Left.transform.position.x;
		
		//把reference object放到目标坐标上
		Vector3 refPos = new Vector3();
		refPos.x = platePos.x + plateRef.x;
		refPos.y = transform.position.y;
		refPos.z = platePos.z + plateRef.y;

		PlateRef.transform.position = refPos;
		
		//让盘子朝向reference object
		transform.LookAt(PlateRef.transform);
		
		//盘子放在中点坐标上
		transform.position = platePos;
		
		





	}
}
