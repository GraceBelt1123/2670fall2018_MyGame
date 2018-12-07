using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMultCoins : MonoBehaviour
{
    //This is to make Multiply Coins to be kept falling down above. 
    public GameObject Prefab;
    public List<GameObject> spawnPoints;
    //public GameObject spawnPoint;
    //public GameObject luckPoint;
    //public GameObject redPoint;
    public float timeToWait = 1;
    public bool canCreateCoins;

    public void StartCoinCreation()
    {
        canCreateCoins = true;
        StartCoroutine(CoinCreation());
    }

    public void EndCoinCreation()
    {
        canCreateCoins = false;
    }

    IEnumerator CoinCreation()
    {
        while (canCreateCoins)
        {
            //randomwly choose a spawn point
            int tempSpawnNum = Random.Range(0, (spawnPoints.Count));
            print(tempSpawnNum);
            GameObject tempSpawn = spawnPoints[tempSpawnNum];
            Instantiate(Prefab, tempSpawn.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToWait);

        }



        /*while (canCreateCoins)
        {
            Instantiate(Prefab, spawnPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToWait);
        }
        
        while (canCreateCoins)
        {
            print("Luck");
            Instantiate(Prefab, luckPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToWait);
        }
        
        while (canCreateCoins)
        {
            print("Red");
            Instantiate(Prefab, redPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeToWait);
            }*/
        
    }   
}


