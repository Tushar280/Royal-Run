using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] GameObject chunkParent;
    [SerializeField] int initialChunkAmt = 10;
    [SerializeField] int speed = 10;

    GameObject[] chunks = new GameObject[10];
    
    void Start()
    {
        ChunkSpawn();
    }

    void Update()
    {
        MoveChunk();
    }

    private void ChunkSpawn()
    {
        for(int i = 0 ; i < initialChunkAmt ; i++)
        {
            transform.position = new Vector3(0,0,i*10f); 
            GameObject newChunk = Instantiate(chunkPrefab, transform.position, Quaternion.identity,chunkParent.transform);
            chunks[i] = newChunk;
            Debug.Log("Chunk Spawned at " + transform.position);
        }
    }

    private void MoveChunk()
    {
        for(int i = 0 ; i < chunks.Length ; i++)
        {
            chunks[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
