using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreUI;
    [SerializeField] TMP_Text coinUI;
    [SerializeField] float scoreFactor;
    float score = 0;
    int coins = 0;

    private void Update()
    {
        score = Time.time * scoreFactor;
        scoreUI.text = ((int)score).ToString();
    }

    public void CollectCoin(int amount)
    {
        coins += amount;
        coinUI.text = coins.ToString();
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
    
}
