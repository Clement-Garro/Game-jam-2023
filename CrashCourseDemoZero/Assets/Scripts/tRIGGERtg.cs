using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tRIGGERtg : MonoBehaviour
{
    [SerializeField] Collider2D player;
    [SerializeField] Collider2D CRONOS;
    void Update()
    {
        //si le collider de la statue touche le collider du joueur
        if (CRONOS.IsTouching(player))
        {
            SceneManager.LoadScene("Scene_Start");
        }
    }
}
