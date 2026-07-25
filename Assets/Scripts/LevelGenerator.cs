using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] GameObject chunkParent;
    [SerializeField] int initialChunkAmt = 10;
    [SerializeField] int speed = 10;

    //List Method
    List<GameObject> chunks = new List<GameObject>(10);
    
    //Array Method
    //GameObject[] chunks = new GameObject[10];
    
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
            chunks.Add(newChunk);
            Debug.Log("Chunk Spawned at " + transform.position);
        }
    }

    private void SpawnNewChunk()
    {
        float chunkZ = chunks[chunks.Count - 1].transform.position.z + 10f;
        transform.position = new Vector3(0,0,chunkZ); 
        GameObject newChunk = Instantiate(chunkPrefab, transform.position, Quaternion.identity,chunkParent.transform);
        chunks.Add(newChunk);
    }

    private void MoveChunk()
    {
        for(int i = 0 ; i < chunks.Count ; i++)
        {
            chunks[i].transform.Translate(Vector3.back * speed * Time.deltaTime);

            if(chunks[i].transform.position.z < Camera.main.transform.position.z)
            {
                Destroy(chunks[i]);
                chunks.RemoveAt(i);
                SpawnNewChunk();  
            }
        }
    }
}
