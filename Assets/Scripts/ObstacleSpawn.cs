using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    [SerializeField] int numToSpawn = 10;

    private void Start()
    {
        for (int i = 0; i < numToSpawn; i++)
        {
            Instantiate(obstacle,transform.position,Quaternion.identity);
        }
    }
}
