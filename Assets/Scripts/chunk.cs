using UnityEngine;
using System.Collections.Generic;

public class chunk : MonoBehaviour
{
    [SerializeField] float[] lanes = {-3.0f,0.0f,3.0f};
    [SerializeField] GameObject fence;

    private void Start()
    {
        SpawnFence();
    }

    private void SpawnFence()
    {

        List<int> availableLanes = new List<int>{0,1,3};
        int fencesToSpawn = Random.Range(0,lanes.Length);

        for(int i = 0; i < fencesToSpawn; i++)
        {
            int randIndex = Random.Range(0,availableLanes.Count);
            int selectedLane = availableLanes[randIndex];
            availableLanes.RemoveAt(randIndex);

            Vector3 pos = new Vector3(lanes[selectedLane],transform.position.y,transform.position.z);
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
    
}
