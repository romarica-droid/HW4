using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update\
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject gameOverText;

    private int score;

    void Start()
    {
        gameOverText.SetActive(false);
        score = 0;
        Locater.Instance.player.addPoint += AddToScore;
        Locater.Instance.player.endGame += ShowText;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    private void AddToScore()
    {
        score++;
    }

    private void ShowText()
    {
        gameOverText.SetActive(true);
    }
}
