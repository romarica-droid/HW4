using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update\
    [SerializeField] private TMP_Text scoreText;

    private int score;

    void Start()
    {
        score = 0;
        Locater.Instance.player.addPoint += AddToScore;
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
}
