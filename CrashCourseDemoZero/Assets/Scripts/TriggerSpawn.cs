using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] Collider2D player;
    [SerializeField] Collider2D statue;
    void Update()
    {
        //si le collider de la statue touche le collider du joueur
        if (statue.IsTouching(player))
        {
            print("t gay");
            SceneManager.LoadScene("Scene_Epoque_1");
        }
    }
}
