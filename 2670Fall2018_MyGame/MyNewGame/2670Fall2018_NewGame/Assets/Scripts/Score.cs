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
  public bool LuckScore;
  
  public void EndScore()
  {
    if (LuckScore)
    {
      Greater.SetActive(true);
    }

    if (!LuckScore)
    {
      Less.SetActive(true);
    }
  }
}

