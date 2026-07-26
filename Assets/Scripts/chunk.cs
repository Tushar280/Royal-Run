using UnityEngine;

public class chunk : MonoBehaviour
{
    [SerializeField] float[] lanes = {-3.0f,0.0f,3.0f};
    [SerializeField] GameObject fence;

    private void Start()
    {
        Vector3 pos = new Vector3(lanes[Random.Range(0,lanes.Length)],transform.position.y,transform.position.z);
        Instantiate(fence,pos,Quaternion.identity,transform);   
    }

    
}
