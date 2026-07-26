using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] int numToSpawn = 10;
    [SerializeField] int waitPerSpawn = 2;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }


    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            Instantiate(obstacles[Random.Range(0,obstacles.Length)],transform.position,Random.rotation);
            numToSpawn--;
            yield return new WaitForSeconds(waitPerSpawn);
        }
    }
}
