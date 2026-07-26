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
            Vector3 spawnPos = new Vector3(Random.Range(-3.0f,3.0f),transform.position.y,transform.position.z);
            Instantiate(obstacles[Random.Range(0,obstacles.Length)],spawnPos,Random.rotation,obstacleParent.transform);
            numToSpawn--;
            yield return new WaitForSeconds(waitPerSpawn);
        }
    }
}
