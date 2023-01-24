using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject hotbar;
    [SerializeField] GameObject player;
    private void Update()
{
    if (Input.GetKeyDown(KeyCode.I))
    {
        panel.SetActive(!panel.activeInHierarchy);
        hotbar.SetActive(!hotbar.activeInHierarchy);
        if (!panel.activeSelf)
        {
            player.setMove(false);
        } else
        {
            player.setMove();
        }
    }
}
}
