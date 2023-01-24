using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] PlayerController player;
    [SerializeField] int damage;
    Animator animator;
    public float health = 1;
    public float speed = 1;
    bool canMove = true;
    public float Health
    {
        set
        {
            health = value;
            if (health <= 0) Defeated();
        }
        get { return health; }
    }

    public float Speed
    {
        set
        {
            speed = value;
        }
        get { return speed; }
    }

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Defeated()
    {
        animator.SetTrigger("dead");
    }
    
    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void goOnPlayer()
    {
        if (canMove)
        {
            //l'enemy ce deplace vers le joueur a t'elle vitesse
            
            //si la box collider du joueur touche la box collider de l'enemy alors le joueur prend des degats
        }
    }
    public void LockMovement()
    {
        canMove = false;
    }
    public void UnlockMovement()
    {
        canMove = true;
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        player.getHit(damage);
    }
}