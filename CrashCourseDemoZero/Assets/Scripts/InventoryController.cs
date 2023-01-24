using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject hotbar;
    [SerializeField] PlayerController player;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
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
}
