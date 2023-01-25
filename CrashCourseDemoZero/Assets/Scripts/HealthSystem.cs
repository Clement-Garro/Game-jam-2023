using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public CountDownTimer timer;
    [FormerlySerializedAs("DeathScreen")] public GameObject deathScreen;
    [FormerlySerializedAs("DeathText")] public GameObject deathText;
    [FormerlySerializedAs("TimeUpText")] public GameObject timeUpText;
    public float temps = 30f;
    public int duration = 2;
    public int health;
    public int numOfHearts;
    
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Start()
    {
        deathScreen.SetActive(false);
        deathText.SetActive(false);
        timeUpText.SetActive(false);
    }

    void Update()
    {
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }
        
        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        while (timer.TimeLeft >= 0)
        {
            if (health <= 0 && timer.TimeLeft > 0)
            {
                timer.EnleverTemps(temps);
                timer.StopTimer();
                StartCoroutine(DeathScreen());
                StartCoroutine(Revive());
            }
        }
        // Lock le joueur
        StartCoroutine(TimeUp());
    }
    
    IEnumerator DeathScreen()
    {
        yield return new WaitForSeconds(duration);
        deathScreen.SetActive(true);
        yield return new WaitForSeconds(duration);
        deathText.SetActive(true);
    }
    
    IEnumerator Revive()
    {
        yield return new WaitForSeconds(duration);
        deathScreen.SetActive(false);
        yield return new WaitForSeconds(duration);
        deathText.SetActive(false);
    }
    
    IEnumerator TimeUp()
    {
        yield return new WaitForSeconds(duration);
        deathScreen.SetActive(true);
        yield return new WaitForSeconds(duration);
        timeUpText.SetActive(true);
    }
}
