using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreUI;
    [SerializeField] float scoreFactor;
    float score;

    private void Update()
    {
        score = score + Time.deltaTime * scoreFactor;
        scoreUI.text = score.ToString();
    }
    
}
