using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Build;
using UnityEngine;

public class CollectCoins : MonoBehaviour {
 //Counting numbers when is entering the Player. 

 public GameObject Player;
 public Vector3 iValue;
 public int sweetCount;
 public float sweetWait;
 public float startWait;
 public float sparkWait;

 public GUIText sweetText;
 private int score;

 void Start()
 {
  score = 0;
  UpdateScore();
  StartCoroutine(LuckBrain());
 }

 IEnumerable LuckBrain()
 {
     yield return new WaitForSeconds(startWait);
     while (true)
     {
         for (int i = 0; i < sweetCount; i++)
         {
             Vector3 tomPosition = new Vector3(Random.Range(-iValue.x, iValue.x), iValue.y, iValue.z);
             Quaternion iRotation = Quaternion.identity;
             Instantiate((Player, tomPosition, iRotation));
             yield return new WaitForSeconds(sparkWait);
         }

         yield return new WaitForSeconds(sparkWait);
     }
 }

    public void Addscore(int newValue)
    {
        score += newValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        sweetText.text = "Score: " + score;
    }
}
