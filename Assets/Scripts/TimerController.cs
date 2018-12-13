using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
	public int score1 =0;
	public int score2 =0;
	public Text Score1;
	public Text Score2;
	public Text fScore1;
	public Text fScore2;
	public GameObject EndImage;
	public Text TimeUI;
	private int minute = 0;
	private int second = 0;
	public float GameTime = 599;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Score1.text = score1.ToString();
		Score2.text = score2.ToString();
			
		GameTime -= Time.deltaTime;
		minute = (int)GameTime / 60;
		second = (int) GameTime % 60;
		if (second >= 10)
		{
			TimeUI.text = "0" + minute.ToString() + " : " + second.ToString();
		}
		else
		{
			TimeUI.text = "0" + minute.ToString() + " : 0" + second.ToString();
		}
		if (GameTime <= 0)
		{
			GameTime = 0;
			fScore1.text = score1.ToString();
			fScore2.text = score2.ToString();
			EndImage.SetActive(true);
			
			//点了restart之后
			//SceneManager.LoadScene(0);

		}
	}
	
	public void restart()
	{
		SceneManager.LoadScene(0);
	}
}
