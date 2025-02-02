﻿using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCoffre : MonoBehaviour
    {
        [SerializeField] PlayerController player1;
        [SerializeField] GameObject SwordPlayer;
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
                SwordPlayer.SetActive(true);
                player1.gameObject.SetActive(false);
                player1.gameObject.SetActive(true);
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
        }
    }
