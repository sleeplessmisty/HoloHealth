using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class TimerCountDown : MonoBehaviour
{
    private float timer = 60f;
    public Text timerText; // Reference to the Text component you want to use

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("f0");

        if (timer <= 0)
        {
            SceneManager.LoadScene("Scenes/Scene3");
        }
    }
}
