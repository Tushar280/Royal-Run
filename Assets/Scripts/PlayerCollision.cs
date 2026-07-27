using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    GameManager gm;

    private void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
    }

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            gm.CollectCoin(1);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            gm.GameOver();
        }
    }
    
}
