using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance

    private int score; // Current score
    private int hiScore; // Hi-Score
    public Text scoreText; // Reference to the UI Text element
    public Text hiScoreText; // Reference to the UI Text element

    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate GameManager instances
        }
    }

    void Start()
    {
        // Load Hi-Score from PlayerPrefs only once at the start
        if (!PlayerPrefs.HasKey("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", 0);
        }
        hiScore = PlayerPrefs.GetInt("HiScore", 0);
        UpdateHiScoreText();

        // Reset current score at the start of each game session
        score = 0;
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;

        // Update Hi-Score if current score is higher
        if (score > hiScore)
        {
            hiScore = score;
            // Save Hi-Score to PlayerPrefs
            PlayerPrefs.SetInt("HiScore", hiScore);
            PlayerPrefs.Save(); // Save changes immediately
            UpdateHiScoreText();
        }
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    void UpdateHiScoreText()
    {
        hiScoreText.text = "Hi-Score: " + hiScore;
    }

    public int GetScore()
    {
        return score;
    }

    public int GetHiScore()
    {
        return hiScore;
    }
}
