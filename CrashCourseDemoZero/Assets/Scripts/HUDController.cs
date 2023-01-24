using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject hotbar;
    [SerializeField] GameObject esc;
    [SerializeField] GameObject hud;
    [SerializeField] CountDownTimer timer;
    [SerializeField] PlayerController player;
    [SerializeField] GameObject enemy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!esc.activeInHierarchy)
            {
            panel.SetActive(!panel.activeInHierarchy);
            hotbar.SetActive(!hotbar.activeInHierarchy);
            
                if (panel.activeInHierarchy)
                {
                    player.LockMovement();
                    timer.StopTimer();
                }
                else
                {
                    player.UnlockMovement();
                    timer.StartTimer();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(false);
            hotbar.SetActive(false);
            esc.SetActive(!esc.activeInHierarchy);
            if (esc.activeInHierarchy)
            {
                timer.StopTimer();
                player.LockMovement();
            } else {
                timer.StartTimer();
                player.UnlockMovement();
                hotbar.SetActive(true);
            }
        }
    }
    
    //fonction qui permet d'instancier une liste d'Enemy[] par le gameObject qui contient tout les enemy
    public void freezeEnemy(){
        Enemy[] enemies = enemy.GetComponentsInChildren<Enemy>();
        foreach (Enemy e in enemies)
        {
            e.LockMovement();
        }
    }
}


