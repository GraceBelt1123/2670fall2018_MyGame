using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Build;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoins : MonoBehaviour
{
    //Counting numbers when is entering the Player. 

    public GameObject Player;
    public Vector3 iValue;
    public int sweetCount;
    public float sweetWait;
    public float startWait;
    public float sparkWait;

    public Score score;

    void Start()
    {
        score.score = 0;
        score.UpdateScore();
        //StartCoroutine(LuckBrain());
    }

    void OnTriggerEnter()
    {
        score.Addscore(1);
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
                //Instantiate((Player, tomPosition, iRotation));
                yield return new WaitForSeconds(sparkWait);
            }

            yield return new WaitForSeconds(sparkWait);
        }
    }
}