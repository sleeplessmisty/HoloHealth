using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScore; // Reference to the UI Text element
    public Text HiScore; // Reference to the UI Text element
    public Text totalDistance; // Reference to the UI Text element

    void Start()
    {
        // Get the score from the GameManager and display it
        int score = GameManager.instance.GetScore();
        int hiscore = GameManager.instance.GetHiScore();
        float distance = DistanceTraveled.instance.GetDistance();

        finalScore.text = "Final Score: " + score.ToString();
        HiScore.text = "Hi-Score: " + hiscore.ToString();
        totalDistance.text = "Distance: " + distance.ToString("f2") + "m";
    }
}