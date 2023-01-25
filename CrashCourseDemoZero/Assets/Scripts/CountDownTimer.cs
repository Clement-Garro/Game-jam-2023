using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 500f;
    public float TimeLeft;
    bool timerIsRunning = true;
    public Text TimerText;

    void Start()
    {
        timerBar = GetComponent<Image>();
        TimeLeft = maxTime;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
                timerBar.fillAmount = TimeLeft / maxTime;
            }
            else
            {
                TimeLeft = 0;
                timerIsRunning = false;
                // Exécutez l'instruction recommencer la partie
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void StopTimer()
    {
        timerIsRunning = false;
    }
    public void StartTimer()
    {
        timerIsRunning = true;
    }
    public void EnleverTemps(float temps)
    {
        TimeLeft -= temps;
    }
}
