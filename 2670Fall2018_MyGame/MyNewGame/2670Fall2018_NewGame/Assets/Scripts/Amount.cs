using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Amount : MonoBehaviour
{
	public FinalScore Amounts;
	public Text PurchasedText;

	public void Update()
	{
		PurchasedText.text = "$: " + Amounts.Money.ToString();
		if (SceneManager.GetActiveScene().name == "Main_Menu")
		{
			Destroy(gameObject);
		}
	}

	public void FinalScoreScore(int Cash)
	{
		Amounts.Money += Cash;
		PurchasedText.text = "S: " + Amounts.Money.ToString();
	}
}
