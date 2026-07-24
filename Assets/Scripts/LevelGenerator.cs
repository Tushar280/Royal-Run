using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("Level Generated"+i);
        }
    }
}
