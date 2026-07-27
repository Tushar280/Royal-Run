using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreUI;
    [SerializeField] float scoreFactor;
    float score = 0;

    private void Update()
    {
        score = Time.deltaTime * scoreFactor;
        scoreUI.text = score.ToString("2D");
    }
    
}
