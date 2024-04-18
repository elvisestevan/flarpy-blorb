using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{

    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    private bool _isGameOver;

    public bool isGameOver
    {
        get => _isGameOver;
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        _isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        _isGameOver = true;
        gameOverScreen.SetActive(true);
    }
}
