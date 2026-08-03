using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreUI;
    [SerializeField] TMP_Text coinUI;
    [SerializeField] TMP_Text lifeUI;

    [SerializeField] float scoreFactor;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] Image red;
    [SerializeField] Button playAgainButton;
    [SerializeField] Button menuButton;

    float score = 0;
    int coins = 0;
    int life = 3;

    private void Update()
    {
        score = Time.time * scoreFactor;
        scoreUI.text = ((int)score).ToString();

        if(life <=0)
        {
            //Death Screen
            GameOverUI.SetActive(true);
            //Red border effect
        }
    }

    public void CollectCoin(int amount)
    {
        coins += amount;
        coinUI.text = coins.ToString();
    }

    public void ChangeLife(int amount)
    {
        red.gameObject.SetActive(true);
        Invoke("StopRed", 0.2f);
        life += amount;
        lifeUI.text = life.ToString();
    }
    void StopRed()
    {
        red.gameObject.SetActive(false);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
