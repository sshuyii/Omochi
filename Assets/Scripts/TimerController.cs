using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{

	public GameObject EndImage;

	public float GameTime = 600;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GameTime -= Time.deltaTime;

		if (GameTime <= 0)
		{
			EndImage.SetActive(true);
			
			//点了restart之后
			SceneManager.LoadScene(0);

		}
	}
}
