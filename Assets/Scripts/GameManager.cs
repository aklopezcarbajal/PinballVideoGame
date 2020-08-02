using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

    public void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("Restart", 1.5f);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
