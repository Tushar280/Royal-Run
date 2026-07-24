using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] GameObject chunkParent;
    [SerializeField] int initialChunkAmt = 10;
    
    void Start()
    {
        for(int i = 0 ; i < initialChunkAmt ; i++)
        {
            transform.position = new Vector3(0,0,i*10f); 
            Instantiate(chunkPrefab, transform.position, Quaternion.identity,chunkParent.transform);
            Debug.Log("Chunk Spawned at " + transform.position);
        }
    }
}
