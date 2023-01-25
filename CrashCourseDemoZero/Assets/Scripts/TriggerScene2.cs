using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class TriggerScene2 : MonoBehaviour
    {
        [SerializeField] PlayerController player1;
        [SerializeField] HealthSystem healthSystem;
        [SerializeField] GameObject Armor2;
        [SerializeField] Collider2D player;
        [SerializeField] Collider2D slime;
        void Update()
        {
            //si le collider de la statue touche le collider du joueur
            if (slime.IsTouching(player))
            {
                player1.C = true;
                player1.D = true;
                Armor2.SetActive(true);
                player1.gameObject.SetActive(false);
                player1.gameObject.SetActive(true);
                //rajoute un coeur au joueur
                healthSystem.numOfHearts++;
                healthSystem.health++;
                SceneManager.LoadScene("Scene_Epoque_2");
            }
        }
    }