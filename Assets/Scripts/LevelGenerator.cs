using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] GameObject chunkPrefab;
    [SerializeField] int initialChunkAmt = 10;
    
    void Start()
    {
        for(int i =0;i < initialChunkAmt;i++)
        Instantiate(chunkPrefab, transform.position, Quaternion.identity);
    }
}
