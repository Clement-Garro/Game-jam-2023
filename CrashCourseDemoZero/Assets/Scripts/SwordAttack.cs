using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordCollider;
    Vector2 rightAttackOffset;
    public float damage = 4;

    private void Start()
    {
        swordCollider = GetComponent<Collider2D>();
        rightAttackOffset = transform.position;
    }

    public void AttackRight()
    {
        // print("AttackRight");
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft()
    {
        // print("AttackLeft");
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void AttackUp()
    {
        // print("AttackUp");
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x, rightAttackOffset.y * 2);
    }

    public void AttackDown()
    {
        // print("AttackDown");
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            Enemy enemy = col.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }
}