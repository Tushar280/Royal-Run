using UnityEngine;

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
        int RandomNum = Random.Range(0,3);
        for(int i = 0;i <= RandomNum; i++)
        {
        Vector3 pos = new Vector3(lanes[Random.Range(0,lanes.Length)],transform.position.y,transform.position.z);
        Instantiate(fence,pos,Quaternion.identity,transform);
        }
        
        
    }
    
}
