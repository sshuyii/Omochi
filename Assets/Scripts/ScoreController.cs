using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

	public Text PlayerScore;
	public int Score;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerScore.text = Score.ToString();


	}

	private void OnTriggerEnter(Collider other)
	{
		//如果banana掉到player1的锅里了
		if (other.CompareTag("PeaT"))
		{
			Score += 5;

		}
		
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("CarrotT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("PumpkinT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("PotatoT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("MushroomT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("OnionT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("TomatoT"))
		{
			Score += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("GarlicT"))
		{
			Score += 5;

		}

		
	}
}
