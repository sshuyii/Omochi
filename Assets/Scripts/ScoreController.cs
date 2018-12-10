using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

	public Text PlayerScore;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	private void OnTriggerEnter(Collider other)
	{
		//如果banana掉到player1的锅里了
		if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		//如果banana掉到player1的锅里了
		else if (other.CompareTag("BananaT"))
		{
			PlayerScore.text += 5;

		}
		
	}
}
