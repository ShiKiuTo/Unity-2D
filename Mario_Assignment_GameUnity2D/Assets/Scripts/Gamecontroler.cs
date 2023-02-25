using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroler : MonoBehaviour
{
    public static Gamecontroler instance;
    public Text scoreText;
    public Text gameOverScoreText;
    public GameObject gameOverText;
    public bool isGameOver = false;

    private int score = 0;
    // khởi gán instance
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
    // khỏi gán đểm số
    public void AddScore(int score)
    {
        this.score += score;
        scoreText.text = "Điểm: " + this.score;
    }
    public void GameOver()
    {
        gameOverScoreText.text = "Điểm của bạn: " + this.score;
        gameOverText.SetActive(true);

        isGameOver = true;
    }
}
