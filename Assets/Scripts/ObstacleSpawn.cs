using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;
    [SerializeField] int numToSpawn = 10;
    [SerializeField] int waitPerSpawn = 2;
    [SerializeField] GameObject obstacleParent;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }


    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            Instantiate(obstacles[Random.Range(0,obstacles.Length)],transform.position,Random.rotation,obstacleParent.transform);
            numToSpawn--;
            yield return new WaitForSeconds(waitPerSpawn);
        }
    }
}
