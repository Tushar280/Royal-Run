using UnityEngine;
using System.Collections.Generic;

public class chunk : MonoBehaviour
{
    [SerializeField] float[] lanes = {-3.0f,0.0f,3.0f};
    [SerializeField] GameObject fence;
    [SerializeField] GameObject Coin;

    List<int> availableLanes = new List<int>{0,1,2};

    private void Start()
    {
        SpawnFence();
        SpawnCoin();
    }

    private void SpawnFence()
    {

        
        int fencesToSpawn = Random.Range(0,lanes.Length);

        for(int i = 0; i < fencesToSpawn; i++)
        {
            if(availableLanes.Count <= 0) break;

            int randIndex = Random.Range(0,availableLanes.Count);
            int selectedLane = availableLanes[randIndex];
            availableLanes.RemoveAt(randIndex);

            Vector3 pos = new Vector3(lanes[selectedLane],transform.position.y - 0.5f,transform.position.z);
            Instantiate(fence,pos,Quaternion.identity,transform);
        }

        /*RNG Solution
        int RandomNum = Random.Range(0,3);
        for(int i = 0;i <= RandomNum; i++)
        {
        Vector3 pos = new Vector3(lanes[Random.Range(0,lanes.Length)],transform.position.y,transform.position.z);
        Instantiate(fence,pos,Quaternion.identity,transform);
        }*/
        
        
    }

    private void SpawnCoin()
    {
        int availableLane = availableLanes[0];
        Vector3 spawnPos = new Vector3(lanes[availableLane],transform.position.y + 1,transform.position.z);
        Instantiate(Coin,spawnPos,Quaternion.identity,transform);
    }
    
}
