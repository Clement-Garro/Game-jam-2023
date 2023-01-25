using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDesert : MonoBehaviour
{
    [SerializeField] GameObject slime1;
    [SerializeField] Collider2D player;
    [SerializeField] Collider2D slime;
    [SerializeField] Collider2D trigger;
    bool toucher = false;
    void Update()
    {
        
        if (trigger.IsTouching(player) && toucher == false){
            slime1.SetActive(true);
            trigger.enabled = false;
            toucher = true;
        }
        
        if (slime.IsTouching(player))
        {
            SceneManager.LoadScene("Scene_Final");
        }
    }
}
