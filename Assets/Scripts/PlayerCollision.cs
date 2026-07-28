using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] Animator anim;
    GameManager gm;
    

    private void Start()
    {
        gm = FindFirstObjectByType<GameManager>();
    }

     private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            gm.CollectCoin(10);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            gm.ChangeLife(-1);
        }
        else if(other.gameObject.CompareTag("Fence"))
        {
            anim.SetTrigger("Hit");
        }
    }
    
}
