using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject hotbar;

private void Update()
{
    if (Input.GetKeyDown(KeyCode.I))
    {
        panel.SetActive(!panel.activeInHierarchy);
        hotbar.SetActive(!hotbar.activeInHierarchy);
    }
}
}
