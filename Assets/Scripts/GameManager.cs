using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreUI;
    [SerializeField] float scoreFactor;
    float score = 0;

    private void Update()
    {
        score = Time.time * scoreFactor;
        scoreUI.text = ((int)score).ToString();
    }
    
}
