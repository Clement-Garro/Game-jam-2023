using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject hotbar;
    [SerializeField] GameObject esc;
    [SerializeField] PlayerController player;

    public void PlayButton(){
        esc.SetActive(false);
        hotbar.SetActive(true);
        player.UnlockMovement();
    }

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
                }
                else
                {
                    player.UnlockMovement();
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
                player.LockMovement();
            } else {
                player.UnlockMovement();
                hotbar.SetActive(true);
            }
        }
    }

}


