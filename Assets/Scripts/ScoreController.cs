using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

	public Text PlayerScore;
	public int Score1;
	public int Player;
	public int Score2;
	public int DishGenerateType;
	public string DishPotName;
	public bool isPutInPot = false;


	//vegetables
//	public GameObject PeaText;
//	public GameObject BananaText;
//	public GameObject CarrotText;
//	public GameObject PumpkinText;
	public GameObject PotatoText;
//	public GameObject MushroomText;
//	public GameObject OnionText;
//	public GameObject TomatoText;
//	public GameObject GarlicText;
//	
//	//meat
//	public GameObject ShrimpText;
//	public GameObject MeatballText;
//	public GameObject SausageText;
//	public GameObject ChickenText;
//	public GameObject SteakText;
//	public GameObject CrayfishText;
//	public GameObject BaconText;
//	public GameObject CrabText;
//	public GameObject TempuraText;
	
	// Use this for initialization
	void Start ()
	{
		DishGenerator();

	}
	
	// Update is called once per frame
	void Update () {
		PlayerScore.text = Score1.ToString();

		//DishGenerateType = (int) Random.Range(0.0f, 19.0f);
		

		//判断并生成锅里需要什么东西
		if (DishGenerateType == 1)
		{
			DishPotName = "PotatoT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/PotatoText");

		}
		else if (DishGenerateType == 2)
		{
			DishPotName = "GarlicT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/GarlicText");
			
		}
		else if (DishGenerateType == 3)
		{
			DishPotName = "PeaT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/PeaText");
			
		}
		else if (DishGenerateType == 4)
		{
			DishPotName = "BananaT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/BananaText");
			
		}
		else if (DishGenerateType == 5)
		{
			DishPotName = "CarrotT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/CarrotText");
			
		}
		else if (DishGenerateType == 6)
		{
			DishPotName = "PumpkinT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/PumpkinText");
			
		}
		else if (DishGenerateType == 7)
		{
			DishPotName = "MushroomT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/MushroomText");
			
		}
		else if (DishGenerateType == 8)
		{
			DishPotName = "OnionT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/OnionText");
			
		}
		else if (DishGenerateType == 9)
		{
			DishPotName = "TomatoT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/TomatoText");
			
		}
		else if (DishGenerateType == 11)
		{
			DishPotName = "ShrimpT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/ShrimpText");
			
		}
		else if (DishGenerateType == 12)
		{
			DishPotName = "MeatballT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/MeatballText");
			
		}
		else if (DishGenerateType == 13)
		{
			DishPotName = "SausageT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/SausageText");
			
		}
		else if (DishGenerateType == 14)
		{
			DishPotName = "ChickenT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/ChickenText");
			
		}
		else if (DishGenerateType == 15)
		{
			DishPotName = "SteakT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/SteakText");
			
		}
		else if (DishGenerateType == 16)
		{
			DishPotName = "CrayfishT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/CrayfishText");
			
		}
		else if (DishGenerateType == 17)
		{
			DishPotName = "BaconT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/BaconText");
			
		}
		else if (DishGenerateType == 18)
		{
			DishPotName = "CrabT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/CrabText");
			
		}
		else if (DishGenerateType == 19)
		{
			DishPotName = "TempuraT";
			PotatoText.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/TempuraText");
			
		}
		


	}

	private void OnTriggerEnter(Collider other)
	{
		//如果banana掉到player1的锅里了
		if (other.CompareTag(DishPotName))
		{
			if (Player == 1)
			{
				Score1 += 5;
			}
			else if (Player == 2)
			{
				Score2 += 5;
			}


			if (isPutInPot == false)
			{
				isPutInPot = true;
				StartCoroutine(Example());
			}


		}
		

		
	}
	
	IEnumerator Example()
	{
		PotatoText.GetComponent<SpriteRenderer>().sprite = null;
		yield return new WaitForSeconds(3);
		isPutInPot = false;
		DishGenerator();

		
	}
	
	public void DishGenerator()
	{

		while (true)
		{
			DishGenerateType = (int) Random.Range(0.0f, 19.0f);
			if (DishGenerateType != 10)
			{
				

				break;
			}


		}
		
	}
}
