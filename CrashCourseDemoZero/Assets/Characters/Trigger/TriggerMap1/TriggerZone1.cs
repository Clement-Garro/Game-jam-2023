// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class TriggerZone1 : MonoBehaviour
// {
//     [SerializeField] PlayerController player;
//     [SerializeField] GameObject OpenChest;
//     [SerializeField] Animator animator;
//     [SerializeField] GameObject sword;
//     [SerializeField] GameObject enemy;
//     [SerializeField] Collider2D colPlayer;
//     [SerializeField] Collider2D coffre;
//     [SerializeField] Collider2D TriggerBoss;
//     [SerializeField] Enemy Boss;
//     [SerializeField] HealthSystem healthSystem;
//     bool truc = true, coffrela=true;
//
//     public void Update()
//     {
//         if (coffrela)
//         {
//             if (colPlayer.IsTouching(coffre))
//             {
//                 EventCoffre();
//             }
//         }
//
//         if (colPlayer.IsTouching(TriggerBoss))
//         {
//             EventBoss();
//         }
//
//         if (Boss.health <= 0)
//         {
//             //passage a la map suivante
//             //debloque l'armure du joueur
//             //gagne un coeur
//             healthSystem.numOfHearts++;
//             healthSystem.health++;
//             player.C = true;
//             player.D = true;
//         }
//     }
// }


// print("coucou c moi");
// Boss.setActive(true);
// Boss.UnlockMovement();
// // while (/*le dialogue n'est pas fini*/)
// // {
// //     //faire le dialogue
// // }
// player.UnlockMovement();

// print("salut");
// player.LockMovement();
// Enemy[] enemies = enemy.GetComponentsInChildren<Enemy>();
// foreach (Enemy e in enemies) 
// { 
//     e.LockMovement();
// }
//player.B = true;
// sword.SetActive(true);
// Destroy(gameObject);
// OpenChest.SetActive(true);
// player.UnlockMovement();
// foreach (Enemy e in enemies)
// {
//     e.UnlockMovement();
// }