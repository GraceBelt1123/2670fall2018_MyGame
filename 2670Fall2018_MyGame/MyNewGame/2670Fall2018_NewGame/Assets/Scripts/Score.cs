using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
  //Game Contoller in this script could be used for score. 
  public GameObject Greater;
  public GameObject Less;
  //public bool LuckScore;
  
  public Text sweetText;
  public int score;
  
  public void Addscore(int newValue)
  {
    score += newValue;
    print(score);
    UpdateScore();
  }

  public void UpdateScore()
  {
    sweetText.text = "Score: " + score;
  }
  
  public void EndScore()
  {
    print(score);
    
    if (score > 5)
    {
      Greater.SetActive(true);
    }

    if (score < 5)
    {
      Less.SetActive(true);
    }
  }
}

