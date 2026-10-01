using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    private int score = 0;
    public void AddScore()
    {
        score++;

        scoreText.SetText("Score: " + score);
        CheckForWin();
    }

    public void CheckForWin()
    {
        if (score == 15 && SceneManager.GetActiveScene().name == "LevelOne")
        {
            SceneManager.LoadScene("LevelOneTransition");
        }
        else if (score == 20 && SceneManager.GetActiveScene().name == "LevelTwo")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
