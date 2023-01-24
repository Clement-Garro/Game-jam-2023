using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 lastDirection;
    public bool canMove = true;
    public SwordAttack swordAttack;
    Vector2 movement;
    SpriteRenderer spriteRenderer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            movement.Normalize();
            rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));

            if (movement.x < 0) spriteRenderer.flipX = true;
            else if (movement.x > 0) spriteRenderer.flipX = false;
        }

        if (movement.x != 0 || movement.y != 0)
        {
            SaveDirection();
        }
    }

    void OnFire()
    {
        animator.SetTrigger("swordAttack");
    }

    public void LockMovement()
    {
        canMove = false;
    }

    public void UnlockMovement()
    {
        canMove = true;
    }

    public void SaveDirection()
    {
        lastDirection = movement;
        animator.SetFloat("LastHorizontal", lastDirection.x);
        animator.SetFloat("LastVertical", lastDirection.y);
    }

    public void SwordAttack()
    {
        LockMovement();
        switch (lastDirection.x)
        {
            case 1 when lastDirection.y == 0:
                swordAttack.AttackRight();
                break;
            case -1 when lastDirection.y == 0:
                swordAttack.AttackLeft();
                break;
            case 0 when lastDirection.y == 1:
                swordAttack.AttackUp();
                break;
            case 0 when lastDirection.y == -1:
                swordAttack.AttackDown();
                break;
            // case 0 when lastDirection.y == 0:
            //     swordAttack.AttackDown();
            //     break;
        }
    }
    
    public void EndSwordAttack()
    {
        UnlockMovement();
        swordAttack.StopAttack();
    }
    
}