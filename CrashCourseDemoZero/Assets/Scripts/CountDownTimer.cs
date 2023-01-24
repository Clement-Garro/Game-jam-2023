using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    public float TimeLeft;

    public Text TimerText;

    void Start()
    {
        timerBar = GetComponent<Image>();
        TimeLeft = maxTime;
    }

    void Update()
    {
        if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
                timerBar.fillAmount = TimeLeft / maxTime;
            }
            else
            {
                TimeLeft = 0;
            }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
