using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score;
    private void Awake()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUI();
    }
    public void IncreaseScore(int add)
    {
        score = score + add;
        RefreshUI();
    }

    public void RefreshUI()
    {
        scoreText.text = "Score : " + score;
    }
}
