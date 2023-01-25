using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCoffre : MonoBehaviour
    {
        [SerializeField] PlayerController player1;
        [SerializeField] Collider2D player;
        [SerializeField] Collider2D Coffre;
        [SerializeField] GameObject Coffre1;
        [SerializeField] GameObject CoffreOuvert;
        [SerializeField] GameObject sword;
        [SerializeField] GameObject Boss;
        [SerializeField] Enemy boss;
        [SerializeField] Collider2D TriggerBoss;
        bool toucher = false, toucherboss = false;

        private void Start()
        {
            sword.SetActive(false);
            Boss.SetActive(false);
            boss.LockMovement();
        }

        void Update()
        {
            //si le collider du coffre touche le collider du joueur
            if (Coffre.IsTouching(player) && toucher == false)
            {
                print("sa marche");
                sword.SetActive(true);
                player1.B = true;
                Coffre1.SetActive(false);
                CoffreOuvert.SetActive(true);
                toucher = true;
            }

            if (TriggerBoss.IsTouching(player) && toucherboss == false)
            {
                print("oui");
                TriggerBoss.enabled = false;
                Boss.SetActive(true);
                boss.UnlockMovement();
                toucherboss = true;
            }

            if (boss.health <= 0)
            {
                //passage a la map suivante
                //debloque l'armure du joueur
                //gagne un coeur
                player1.C = true;
                player1.D = true;
                SceneManager.LoadScene("Scene_Epoque_2");
            }
        }
    }
