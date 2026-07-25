using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    [SerializeField] int numToSpawn = 10;
    [SerializeField] int waitPerSpawn = 3;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }


    IEnumerator SpawnObstacles()
    {
        
        while(numToSpawn > 0)
        {
            Instantiate(obstacle,transform.position,Quaternion.identity);
            numToSpawn--;
            yield return new WaitForSeconds(waitPerSpawn);
        }
    }
}
