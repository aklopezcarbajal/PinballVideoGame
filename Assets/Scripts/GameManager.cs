using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;
    public Text gameOverText;

    void Start()
    {
        gameOverText.text = "";
    }

    public void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;
            gameOverText.text = "GAME OVER";
            Invoke("Restart", 2f);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
